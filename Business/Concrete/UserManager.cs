using Business.Abstract;
using Business.Constants.Messages;
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
        public IResult Add(User user)
        {

            _userDal.Add(user);
            return new SuccessResult(UserMessages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(UserMessages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), UserMessages.UserGetAll);
        }

        public IDataResult<User> GetByMail(string email)
        {
            User get = _userDal.Get(u=>u.Email==email);
            if (get==null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(get);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var get = _userDal.GetClaims(user);
            if (get == null)
            {
                return new ErrorDataResult<List<OperationClaim>>(UserMessages.GetClaimsIsNull);
            }
            return new SuccessDataResult<List<OperationClaim>>(get);
        }




        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password,string passwordRepeat)
        {
            IResult result = BusinessRules.Run(PasswordRepeatCompatibilityWithPassword(password,passwordRepeat));

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




        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(UserMessages.UserUpdated);
        }








        //elave metodlar
        private IResult PasswordRepeatCompatibilityWithPassword(string password,string passwordRepeat)
        {
            if (!password.Equals(passwordRepeat))
            {
                return new ErrorResult(AuthMessages.passwordAndPasswordRepeatNotEquals);
            }
            return new SuccessResult();
        }



    }
}
