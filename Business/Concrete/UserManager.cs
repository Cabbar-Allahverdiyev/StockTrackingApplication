using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Entities.Concrete.ForForms;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        //CRUD

        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(IsThereFirstNameAndLastNameAvailable(user.FirstName, user.LastName)
                                                , IsEmailExists(user.Email)
                                                , PhoneNumberFormatControl(user.PhoneNumber)
                                                , UserFullNameToTitleCase(user));
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            _userDal.Add(user);
            return new SuccessResult(UserMessages.UserAdded);
        }

        

        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Update(User user)
        {
            IResult result = BusinessRules.Run(IsThereFirstNameAndLastNameAvailableForUserUpdate(user)
                                               , IsEmailExistsForUserUpdate(user), PhoneNumberFormatControl(user.PhoneNumber)
                                               , IsPhoneNumberExistsForUserUpdate(user)
                                               , UserFullNameToTitleCase(user)
                                               );

            if (result != null)
            {
                return new ErrorResult(result.Message);
            }

            _userDal.Update(user);
            return new SuccessResult(UserMessages.UserUpdated);
        }

        [CacheRemoveAspect("IUserService.Get")]
        public IResult Delete(User user)
        {
            IResult result = BusinessRules.Run(IsUserExist(user.Id));

            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            _userDal.Delete(user);
            return new SuccessResult(UserMessages.UserDeleted);
        }

        [CacheAspect]
        public IDataResult<List<User>> GetAll()
        {
            List<User> get = _userDal.GetAll();
            if (get == null)
            {
                return new ErrorDataResult<List<User>>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<List<User>>(get, UserMessages.UserGetAll);
        }

        public IDataResult<User> GetById(int id)
        {
            User get = _userDal.Get(u => u.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<User>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<User>(get, UserMessages.UserFound);
        }

        //DTOs
        [CacheAspect]
        public IDataResult<List<UserDto>> GetUserDetails()
        {
            List<UserDto> get = _userDal.GetUserDetails();
            if (get is null)
            {
                return new ErrorDataResult<List<UserDto>>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<List<UserDto>>(get, UserMessages.UserDetailsListed);
        }

        public IDataResult<UserDto> GetUserDetailByMail(string mail)
        {
            UserDto get = _userDal.GetUserDetail(u => u.Email.ToLower() == mail.ToLower(new CultureInfo("en-Us", false)));
            if (get is null)
            {
                return new ErrorDataResult<UserDto>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<UserDto>(get, UserMessages.UserFound);
        }

        public IDataResult<UserDto> GetUserDetailByUserName(string firstName, string lastName)
        {
            UserDto get = _userDal.GetUserDetail(u => u.FirstName.ToLower() == firstName.ToLower(new CultureInfo("en-Us", false))
                                                & u.LastName.ToLower() == lastName.ToLower(new CultureInfo("en-Us", false)));
            if (get is null)
            {
                return new ErrorDataResult<UserDto>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<UserDto>(get, UserMessages.UserFound);
        }

        [CacheAspect]
        public IDataResult<UserDto> GetUserDetailByUserId(int userId)
        {
            var get = _userDal.GetUserDetail(u => u.UserId == userId);
            if (get == null)
            {
                return new ErrorDataResult<UserDto>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<UserDto>(get, UserMessages.UserFound);
        }

        //--------------------------

        public IDataResult<User> GetByMail(string email)
        {
            User get = _userDal.Get(u => u.Email.ToLower() == email.ToLower(new CultureInfo("en-Us", false)));
            if (get == null)
            {
                return new ErrorDataResult<User>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<User>(get);
        }

        [CacheAspect]
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var get = _userDal.GetClaims(user);
            if (get == null)
            {
                return new ErrorDataResult<List<OperationClaim>>(UserMessages.GetClaimsIsNull);
            }
            return new SuccessDataResult<List<OperationClaim>>(get);
        }

        [CacheAspect]
        public IDataResult<List<OperationClaimForForms>> GetClaimsForForms(User user)
        {
            var get = _userDal.GetClaimsForForms(user);
            if (get == null)
            {
                return new ErrorDataResult<List<OperationClaimForForms>>(UserMessages.GetClaimsIsNull);
            }
            return new SuccessDataResult<List<OperationClaimForForms>>(get);
        }



        public IResult CheckUserOperationClaimIsBossAndAdminByUserIdForForms(int userId)
        {
            User getUser = GetById(userId).Data;
            IDataResult<List<OperationClaimForForms>> getClaims = GetClaimsForForms(getUser);
            foreach (OperationClaimForForms claim in getClaims.Data)
            {
                if (claim.Name == "Boss" || claim.Name == "Admin")
                {
                    return new SuccessResult();
                }
            }
            return new ErrorResult(UserMessages.UserDoesNotHaveAdminPermission);
        }

        public IResult CheckUserOperationClaimIsBossByUserIdForForms(int userId)
        {
            User getUser = GetById(userId).Data;
            IDataResult<List<OperationClaimForForms>> getClaims = GetClaimsForForms(getUser);
            foreach (OperationClaimForForms claim in getClaims.Data)
            {
                if (claim.Name == "Boss")
                {
                    return new SuccessResult();
                }

            }
            return new ErrorResult(UserMessages.UserDoesNotHaveBossPermission);
        }





        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto
            //, string passwordRepeat
            )
        {
            IResult result = BusinessRules.Run(PasswordRepeatCompatibilityWithPassword(userForRegisterDto.Password, userForRegisterDto.PasswordRepeat)//passwordRepeat)
                                               , IsPasswordNull(userForRegisterDto.Password)
                                               , IsThePasswordGreaterThanFourCharacters(userForRegisterDto.Password)
                                               , IsThereFirstNameAndLastNameAvailable(userForRegisterDto.FirstName, userForRegisterDto.LastName)
                                               , IsEmailExists(userForRegisterDto.Email)
                                               , IsPhoneNumberExists(userForRegisterDto.PhoneNumber)

                                               );

            if (result != null)
            {
                return new ErrorDataResult<User>(result.Message);
            }


            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email,
                Address = userForRegisterDto.Address,
                PhoneNumber = userForRegisterDto.PhoneNumber,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            IResult userAdded = Add(user);
            if (!userAdded.Success)
            {
                return new ErrorDataResult<User>(userAdded.Message);
            }
            return new SuccessDataResult<User>(user, AuthMessages.UserRegistered);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCeck = GetByMail(userForLoginDto.Email).Data;
            if (userToCeck == null)
            {
                return new ErrorDataResult<User>(UserMessages.UserNotFound);

            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCeck.PasswordHash, userToCeck.PasswordSalt))
            {
                return new ErrorDataResult<User>(UserMessages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCeck, AuthMessages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (this.GetByMail(email).Data != null)
            {
                return new ErrorResult(UserMessages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        //elave metodlar
        private IResult UserFullNameToTitleCase(User user)
        {
            user.FirstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(user.FirstName);
            user.LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(user.LastName);
            return new SuccessResult();
        }
        private IResult PasswordRepeatCompatibilityWithPassword(string password, string passwordRepeat)
        {
            if (!password.Equals(passwordRepeat))
            {
                return new ErrorResult(AuthMessages.passwordAndPasswordRepeatNotEquals);
            }
            return new SuccessResult();
        }

        private IResult IsPasswordNull(string password)
        {
            if (password.Length == 0)
            {
                return new ErrorResult(AuthMessages.PasswordNull);
            }
            return new SuccessResult();
        }
        private IResult IsThePasswordGreaterThanFourCharacters(string password)
        {
            if (password.Length < 4)
            {
                return new ErrorResult(AuthMessages.PasswordIsLessThanFourCharacters);
            }
            return new SuccessResult();
        }

        private IResult IsUserExist(int userId)
        {
            IDataResult<User> result = GetById(userId);
            if (!result.Success)
            {
                return new ErrorResult(UserMessages.UserNotFound);
            }
            return new SuccessResult();
        }

        private IResult IsThereFirstNameAndLastNameAvailable(string firstName, string lastName)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User user in userGetAll)
            {

                if (user.FirstName.ToLower().Equals(firstName.ToLower()))
                {
                    if (user.LastName.ToLower().Equals(lastName.ToLower()))
                    {
                        return new ErrorResult(UserMessages.FirstNameAndLastNameAvailable);
                    }
                }
            }
            return new SuccessResult();
        }

        private IResult IsThereFirstNameAndLastNameAvailableForUserUpdate(User user)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User item in userGetAll)
            {
                if (item.FirstName.ToLower().Equals(user.FirstName.ToLower()) && item.LastName.ToLower().Equals(user.LastName.ToLower()))
                {
                    if (item.Id != user.Id)
                    {
                        return new ErrorResult(UserMessages.FirstNameAndLastNameAvailable);
                    }

                }
            }
            return new SuccessResult();
        }

        private IResult IsEmailExists(string email)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User user in userGetAll)
            {
                if (user.Email.ToLower().Equals(email.ToLower()))
                {
                    return new ErrorResult(UserMessages.EmailAvailable);
                }
            }
            return new SuccessResult();
        }

        private IResult IsEmailExistsForUserUpdate(User user)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User item in userGetAll)
            {
                if (item.Email.ToLower().Equals(user.Email.ToLower()) && item.Id != user.Id)
                {
                    return new ErrorResult(UserMessages.EmailAvailable);
                }
            }
            return new SuccessResult();
        }

        private IResult PhoneNumberFormatControl(string phoneNumber)
        {
            string format = @"^(0(\d{9}))$";
            Match match = Regex.Match(phoneNumber, format, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return new SuccessResult();
            }
            return new ErrorResult(UserMessages.PhoneNumberFormatIsNotSuitable);
        }

        private IResult IsPhoneNumberExists(string phoneNumber)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User item in userGetAll)
            {
                if (item.PhoneNumber.ToLower().Equals(phoneNumber.ToLower()))
                {
                    return new ErrorResult(UserMessages.PhoneNumberAvailable);
                }
            }
            return new SuccessResult();
        }

        private IResult IsPhoneNumberExistsForUserUpdate(User user)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User item in userGetAll)
            {
                if (item.PhoneNumber.ToLower().Equals(user.PhoneNumber.ToLower()) && item.Id != user.Id)
                {
                    return new ErrorResult(UserMessages.PhoneNumberAvailable);
                }
            }
            return new SuccessResult();
        }


    }
}
