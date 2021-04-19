using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Repositories
{
   public interface IUserGroupRepository
    {
        UserGroup CreateGroup(UserGroup userGroup);
        UserGroup DeleteGroup(UserGroup userGroup);
        public Task<IEnumerable<UserGroup>> GetUserGroupsName(string userName);
    }
}
