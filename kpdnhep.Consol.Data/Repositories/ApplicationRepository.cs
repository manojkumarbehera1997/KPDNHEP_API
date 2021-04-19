using Dapper;
using System;
using static System.Data.CommandType;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using KPDNHEP.Console.Data.Repositories;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Models;

namespace KPDNHEP.Console.Data
{
    public class ApplicationRepository : BaseRepository, IApplicationRepository
    {
        public async Task<IEnumerable<Applications>> GetAssignedApplicationsToUser(string userName)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", userName);
            List<Applications> apps = (await SqlMapper.QueryAsync<Applications>(connectionstring, "get_applications_by_username", dynamicParameters, commandType: StoredProcedure)).ToList();
            return apps.ToList();
        }
        public async Task<List<Applications>> GetAllApplications()
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            List<Applications> applications = (await SqlMapper.QueryAsync<Applications>(connectionstring, "get_all_applications", dynamicParameters, commandType: StoredProcedure)).ToList();
            return applications.ToList();
        }
             
        public Applications AddApplication(Applications application)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@ApplicationName", application.ApplicationName);
            dynamicParameters.Add("@ApplicationIcon", application.ApplicationIcon);
            dynamicParameters.Add("@ApplicationUrl", application.ApplicationUrl);
            dynamicParameters.Add("@ApplicationDescription", application.ApplicationDescription);
            dynamicParameters.Add("@IdInserted", dbType: DbType.Int32, direction: ParameterDirection.Output);
            SqlMapper.Query<string>(connectionstring, "add_application", dynamicParameters, commandType: StoredProcedure).FirstOrDefault();
            int appInserted = dynamicParameters.Get<int>("@IdInserted");
            application.ApplicationId = appInserted;
            return application;
        }

        public async Task<IEnumerable<Applications>> GetApplicationsByGroup(string userName, string groupName)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", userName);
            dynamicParameters.Add("@GroupName", groupName);
            List<Applications> applications = (await SqlMapper.QueryAsync<Applications>(connectionstring, "get_applications_by_usersgroup", dynamicParameters, commandType: StoredProcedure)).ToList();
            return applications.ToList();
        }

    }
}
