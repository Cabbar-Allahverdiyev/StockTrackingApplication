using Business.Abstract;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }


        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password,string passwordRepeat)
        {
            //Bu metod artiq UserManager-de Register adi ile
            //byte[] passwordHash, passwordSalt;
            //HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            //var user = new User
            //{
            //    FirstName=userForRegisterDto.FirstName,
            //    LastName=userForRegisterDto.LastName,
            //    Email=userForRegisterDto.Email,
            //    Address=userForRegisterDto.Address,
            //    PhoneNumber=userForRegisterDto.PhoneNumber,
            //    PasswordHash=passwordHash,
            //    PasswordSalt=passwordSalt,
            //    Status=true
            //};
            //_userService.Add(user);
           
            var userRegister=_userService.Register(userForRegisterDto, password, passwordRepeat);
            ////buralara mutleq nezer yetir
            return new SuccessDataResult<User>(AuthMessages.UserRegistered);
        }



        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCeck = _userService.GetByMail(userForLoginDto.Email).Data;
            if (userToCeck==null)
            {
                return new ErrorDataResult<User>(UserMessages.UserNotFound);

            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCeck.PasswordHash,userToCeck.PasswordSalt))
            {
                return new ErrorDataResult<User>(UserMessages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCeck, AuthMessages.SuccessfulLogin);
        }


       




        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult(UserMessages.UserAlreadyExists);
            }
            return new SuccessResult();
        }



        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user).Data;
            var accessToken = _tokenHelper.CreateToken(user, claims);

            //IResult result = BusinessRules.Run();

            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<AccessToken>(accessToken,AuthMessages.AccessTokenCreated);
        }
    }
}
