using FinancialApiDataAccess;
using FinancialApiModel.Dtos;
using FinancialApiService.Repository.Implementation;
using FinancialApiService.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApiProject.Controllers
{
    public class UserController : BaseController
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {

            _userService = userService;

        }

        [HttpGet("get-user/{userId}")]
      
        public async Task<IActionResult> GetUser(string userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no available");
            }
            var user = await _userService.GetUser(userId);
            
            return Ok(user);
            
        }


        [HttpGet("get-users")]

        public async Task<IActionResult> GetUsers()
        { 
            var user = await _userService.GetUsers();
            return Ok(user);
        }

        [HttpPost("open-account")]
        public async Task<IActionResult> AddUser(RegistrationDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid input");
            }
            var res = await _userService.AddUser(model);
            return Ok(res);

        }

        [HttpDelete("delete-user{UserId}")]
        public async Task<IActionResult> DeleUser(string UserId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid resquest");

            }
            var res = await _userService.DeleteUser(UserId);
            return Ok(res);
        }

        [HttpPatch("update-user{UserId}")]

        public async Task<IActionResult> UpdateUser(string UserId, UpdateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid resquest");
            }
            var res = await _userService.UpdateUser(UserId, model);
            return Ok(res);
        }



        
        
    }
}
