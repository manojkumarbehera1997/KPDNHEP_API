using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.API.Controllers
{

    [ApiController]
    [Route("api/v1/UserGroup")]
    public class UserGroupController : ControllerBase
    {
        private readonly IUserGroupService _userGroupService;
        public UserGroupController(IUserGroupService userGroupService)
        {
            _userGroupService = userGroupService;
        }
        /// <summary>
        /// Create Group
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="GroupName"></param>
        /// <returns>string</returns>
        [Route("CreateGroup")]
        [HttpPost]
        public UserGroup CreateGroup(UserGroup userGroup )
        {
            return _userGroupService.CreateUserGroup(userGroup);
        }
        /// <summary>
        /// Delete Groups
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="GroupName"></param>
        /// <returns>string</returns>
        [Route("DeleteGroup")]
        [HttpPost]
        public UserGroup DeleteGroup(UserGroup userGroup)
        {
            return _userGroupService.DeleteUserGroup(userGroup);
        }

        /// <summary>
        /// Get user created group names
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>List of groups</returns>
        [Route("GetGroupNamesByUser/{userName}")]
        [HttpGet]
        public async Task<IEnumerable<UserGroup>> GetGroupNamesByUser(string userName)
        {
            return await _userGroupService.GetUserGroupsName(userName);
        }

    }
}
