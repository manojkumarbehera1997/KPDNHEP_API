using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.API.Controllers
{
    [ApiController]
    [Route("api/v1/UserGroupApplication")]
    public class UserGroupApplicationController : ControllerBase
    {
        private readonly IUserGroupApplicationService _userGroupApplicationService;

        public UserGroupApplicationController(IUserGroupApplicationService userGroupApplicationService)
        {
            _userGroupApplicationService = userGroupApplicationService;
        }

        /// <summary>
        /// Add application to a group
        /// </summary>
        /// <param name="userGroupApplication"></param>
        /// <returns>UserGroupApplication</returns>
        [Route("AddApplicationToGroup")]
        [HttpPost]
        public UserGroupApplication AddApplicationToGroup(UserGroupApplication userGroupApplication)
        {
            return _userGroupApplicationService.AssignApplicationToGroup(userGroupApplication);
        }

    }
}
