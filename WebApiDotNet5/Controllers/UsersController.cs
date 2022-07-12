using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiDotNet5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IDataResult<List<UserDto>> users = _userService.GetUserDetails();
            if (users.Success)
            {
                return Ok(users);
            }
            return BadRequest(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            IDataResult<UserDto> getUser = _userService.GetUserDetailByUserId(id);
            if (getUser.Success)
            {
                return Ok(getUser);
            }
            return BadRequest(getUser);
        }

        [HttpGet("getbymail/{mail}")]
        public IActionResult GetByMail(string mail)
        {
            IDataResult<UserDto> getUser = _userService.GetUserDetailByMail(mail);
            if (getUser.Success)
            {
                return Ok(getUser);
            }
            return BadRequest(getUser);
        }

        [HttpGet("getByUserName")]
        public IActionResult GetByUserName(string userName)
        {

            string firstName = userName.Split(" ")[0];
            string lastName = userName.Split(" ")[1];

            IDataResult<UserDto> getUser = _userService.GetUserDetailByUserName(firstName,lastName);
            if (getUser.Success)
            {
                return Ok(getUser);
            }
            return BadRequest(getUser);
        }

        [HttpDelete]
        public IActionResult Delete(User user)
        {
            IResult deletedUser = _userService.Delete(user);
            if (deletedUser.Success)
            {
                return Ok(deletedUser);
            }
            return BadRequest(deletedUser);
        }

    }
}
