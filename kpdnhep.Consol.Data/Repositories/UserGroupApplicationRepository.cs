using Dapper;
using KPDNHEP.Console.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using KPDNHEP.Console.Domain.Models;

namespace KPDNHEP.Console.Data.Repositories
{
    public class UserGroupApplicationRepository:BaseRepository,IUserGroupApplicationRepository
    {
        public UserGroupApplication AssignApplicationToGroup(UserGroupApplication userGroupApplication)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@NewUserGroupId", userGroupApplication.NewGroupId);
            dynamicParameters.Add("@OldUserGroupId", userGroupApplication.OldGroupId);
            dynamicParameters.Add("@ApplicationId", userGroupApplication.ApplicationId);
            SqlMapper.Query<UserGroupApplication>(connectionstring, "assign_application_to_group", dynamicParameters, commandType:System.Data.CommandType.StoredProcedure).FirstOrDefault();
            return userGroupApplication;
        }
    }
}
