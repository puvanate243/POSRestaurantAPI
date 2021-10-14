using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POSRestaurantAPI.Models;
using POSRestaurantAPI.Services.UserServices;

namespace POSRestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("user_master")]
    public class MS_UserMasterController : ControllerBase
    { 
        private readonly IUserServices _userServices;
        public MS_UserMasterController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [Route("getalluser")]
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _userServices.GetAllUser());
        }
        [Route("getuserbyid")]
        public async Task<IActionResult> GetUserById(string id)
        {
            return Ok(await _userServices.GetUserById(id));
        }
        [Route("getuserbyname")]
        public async Task<IActionResult> GetUserByName(string name)
        {
            return Ok(await _userServices.GetUserByName(name));
        }

        [Route("createuser")]
        [HttpPost]
        public async Task<IActionResult> CreateUser(MS_UserMasterModel user)
        {
            return Ok(await _userServices.CreateUser(user));
        }

        [Route("updateuser")]
        [HttpPatch]
        public async Task<IActionResult> UpdateUser(string id,MS_UserMasterModel user)
        {
            return Ok(await _userServices.UpdateUser(id,user));
        }

        [Route("deleteuser")]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string id)
        {
            return Ok(await _userServices.DeleteUser(id));
        }
    }
}
