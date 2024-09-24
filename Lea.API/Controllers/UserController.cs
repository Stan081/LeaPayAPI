using Lea.Repository.Context;
using Lea.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lea.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController( IUserService userService )
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers(){
            //var users = dbContext.Users.ToList();
            return Ok();
        }
    }
}
