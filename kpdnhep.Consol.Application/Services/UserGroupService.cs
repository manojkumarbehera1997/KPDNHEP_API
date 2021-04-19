using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Application.Services
{
   public class UserGroupService: IUserGroupService
    {
        private readonly IUserGroupRepository _userGroupRepository;

        public UserGroupService(IUserGroupRepository userGroupRepository)
        {
            _userGroupRepository = userGroupRepository;
        }
        public UserGroup CreateUserGroup(UserGroup userGroup)
        {
            return _userGroupRepository.CreateGroup(userGroup);
        }
        public UserGroup DeleteUserGroup(UserGroup userGroup)
        {
            return _userGroupRepository.DeleteGroup(userGroup);
        }
        public Task<IEnumerable<UserGroup>> GetUserGroupsName(string userName)
        {
            return _userGroupRepository.GetUserGroupsName(userName);
        }

   }
}
