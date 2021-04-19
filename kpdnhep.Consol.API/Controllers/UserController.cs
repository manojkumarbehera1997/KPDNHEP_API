using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace KPDNHEP.Console.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userervice)
        {
            _userService = userervice;
        }
        /// <summary>
        /// Create Group
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns>string</returns>
        [Route("UserLogin")]
        [HttpPost]
        public UserAuthentication UserLogin(UserAuthentication userAuthentication)
        {
            return _userService.UserLogin(userAuthentication);
        }
    }
}
