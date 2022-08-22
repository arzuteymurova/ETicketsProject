﻿using Business.Abstract;
using Core.Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getuserdetailsbymail")]
        public IActionResult GetUserDetailByMail(string userMail)
        {
            var result = _userService.GetUserDetailByMail(userMail);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("updateuserdetails")]
        public IActionResult UpdateUserDetails(UserDetailForUpdateDto userDetailForUpdate)
        {
            var result = _userService.UpdateUserDetails(userDetailForUpdate);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}
