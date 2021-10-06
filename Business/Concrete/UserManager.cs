using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

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
                                                , IsEmailExists(user.Email));
            if (result != null)
            {
                return new ErrorDataResult<User>(result.Message);
            }
            _userDal.Add(user);
            return new SuccessResult(UserMessages.UserAdded);
        }

        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(UserMessages.UserUpdated);
        }

        [CacheRemoveAspect("IUserService.Get")]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(UserMessages.UserDeleted);
        }

        [CacheAspect]
        public IDataResult<List<User>> GetAll()
        {
            List<User> get = _userDal.GetAll();
            if (get is null)
            {
                return new ErrorDataResult<List<User>>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<List<User>>(get, UserMessages.UserGetAll);
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

        public IDataResult<List<UserDto>> GetUserDetailsByUserName(string userName)
        {
            List<UserDto> get = _userDal.GetUserDetails(u => u.FirstName == userName);
            if (get is null)
            {
                return new ErrorDataResult<List<UserDto>>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<List<UserDto>>(get, UserMessages.UserDetailsByNameListed);
        }

        [CacheAspect]
        public IDataResult<List<UserDto>> GetUserDetailsByUserId(int userId)
        {
            var get = _userDal.GetUserDetails(u => u.UserId == userId);
            if (get == null)
            {
                return new ErrorDataResult<List<UserDto>>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<List<UserDto>>(get, UserMessages.UserDetailsListed);
        }

        public IDataResult<UserDto> GetUserDetail(int userId)
        {
            UserDto get = _userDal.GetUserDetail(userId);
            if (get == null)
            {
                return new ErrorDataResult<UserDto>(UserMessages.UserNotFound);
            }
            return new SuccessDataResult<UserDto>(get, UserMessages.UserDetailsListed);
        }


        //--------------------------

        public IDataResult<User> GetByMail(string email)
        {
            User get = _userDal.Get(u => u.Email == email);
            if (get == null)
            {
                return new ErrorDataResult<User>();
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





        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password, string passwordRepeat)
        {
            IResult result = BusinessRules.Run(PasswordRepeatCompatibilityWithPassword(password, passwordRepeat)
                                               , IsPasswordNull(password)
                                               , PasswordCannotBeLessThanSixCharacters(password)
                                               , IsThereFirstNameAndLastNameAvailable(userForRegisterDto.FirstName, userForRegisterDto.LastName)
                                               , IsEmailExists(userForRegisterDto.Email)
                                               );

            if (result != null)
            {
                return new ErrorDataResult<User>(result.Message);
            }


            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
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

            Add(user);
            return new SuccessDataResult<User>(user, AuthMessages.UserRegistered);
        }












        //elave metodlar
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

        private IResult PasswordCannotBeLessThanSixCharacters(string password)
        {
            if (password.Length >= 6)
            {
                return new ErrorResult(AuthMessages.PasswordLessThanSixCharacters);
            }
            return new SuccessResult();
        }

        private IResult IsThereFirstNameAndLastNameAvailable(string firstName, string lastName)
        {
            List<User> userGetAll = _userDal.GetAll();
            foreach (User user in userGetAll)
            {
                if (user.FirstName.Equals(firstName))
                {
                    if (user.LastName.Equals(lastName))
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
                if (user.Email.Equals(email))
                {
                    return new ErrorResult(UserMessages.EmailAvailable);
                }
            }
            return new SuccessResult();
        }



    }
}
