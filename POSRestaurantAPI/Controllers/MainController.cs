using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace POSRestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ObjectResult GetStart()
        {
            return Ok("Welcome to my API...");
        }
    }
}
