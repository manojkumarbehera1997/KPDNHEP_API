using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Services
{
   public interface IUserGroupService
    {
        UserGroup CreateUserGroup(UserGroup userGroup);
        UserGroup DeleteUserGroup(UserGroup userGroup);
        public Task<IEnumerable<UserGroup>> GetUserGroupsName(string userName);
    }
}
