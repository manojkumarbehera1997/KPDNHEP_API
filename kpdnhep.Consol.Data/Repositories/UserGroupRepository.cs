using Dapper;
using KPDNHEP.Console.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using KPDNHEP.Console.Domain.Models;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Data.Repositories
{
   public class UserGroupRepository : BaseRepository, IUserGroupRepository
    {
        public UserGroup CreateGroup(UserGroup userGroup)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", userGroup.UserName);
            dynamicParameters.Add("@GroupName", userGroup.GroupName);
            string result = SqlMapper.Query<string>(connectionstring, "create_group", dynamicParameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            if (result != "")
            {
                userGroup.GroupName = result;
                return userGroup;
            }
                
            else
            {
                userGroup.GroupName = "error";
                return userGroup;
            }
        }
        public UserGroup DeleteGroup(UserGroup userGroup)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", userGroup.UserName);
            dynamicParameters.Add("@GroupName", userGroup.GroupName);
            string result = SqlMapper.Query<string>(connectionstring, "delete_group", dynamicParameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            if (result != "")
            {
                userGroup.GroupName = result;
                return userGroup;
            }

            else
            {
                userGroup.GroupName = "error";
                return userGroup;
            }
        }
        public async Task<IEnumerable<UserGroup>> GetUserGroupsName(string userName)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", userName);
            List<UserGroup> apps = (await SqlMapper.QueryAsync<UserGroup>(connectionstring, "get_user_groups", dynamicParameters, commandType: System.Data.CommandType.StoredProcedure)).ToList();
            return apps.ToList();
        }
    }
}
