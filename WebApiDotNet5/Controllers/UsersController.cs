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
            IDataResult<UserDto> getUser = _userService.GetUserDetailsByUserId(id);
            if (getUser.Success)
            {
                return Ok(getUser);
            }
            return BadRequest(getUser);
        }
    }
}
