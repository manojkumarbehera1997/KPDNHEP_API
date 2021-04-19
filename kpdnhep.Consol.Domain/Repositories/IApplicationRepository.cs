using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace KPDNHEP.Console.Domain.Repositories
{
    public interface IApplicationRepository
    {
        Task<IEnumerable<Applications>> GetAssignedApplicationsToUser(string userName);
        Task<List<Applications>> GetAllApplications();
        Applications AddApplication(Applications application);
        Task<IEnumerable<Applications>> GetApplicationsByGroup(string userName,string groupName);

    }
}
