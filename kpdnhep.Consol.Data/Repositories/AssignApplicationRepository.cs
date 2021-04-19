using Dapper;
using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.CommandType;

namespace KPDNHEP.Console.Data.Repositories
{
   public class AssignApplicationRepository: BaseRepository, IAssignApplicationRepository
    {
        public AssignApplication GetAssignedApplicationIdsToUser(AssignApplication assignApplication)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", assignApplication.UserName);
            var ids= SqlMapper.Query<string>(connectionstring, "get_assigned_applications_by_username", dynamicParameters, commandType: StoredProcedure).FirstOrDefault();
            assignApplication.AssignedApplications =Convert.ToString(ids);
            return assignApplication;
        }

        public AssignApplication AssignApplicationsToUser(AssignApplication assignApplication)
        {
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@UserName", assignApplication.UserName);
                dynamicParameters.Add("@AssignedApplications", assignApplication.AssignedApplications);
                dynamicParameters.Add("@InsertedId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                SqlMapper.ExecuteAsync(connectionstring, "assign_applications_to_user", dynamicParameters, commandType: StoredProcedure);
                int user_inserted = dynamicParameters.Get<int>("@InsertedId");
                assignApplication.AssignedApplicationId = user_inserted;
                return assignApplication;
            }
            catch (Exception message)
            {
                assignApplication.AssignedApplicationId = 0;
                return assignApplication;
            }
        }
    }
}
