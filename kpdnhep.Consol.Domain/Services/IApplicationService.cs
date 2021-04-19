using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace KPDNHEP.Console.Domain.Services
{
    public interface IApplicationService//: IService<Apps>
    {
        Task<IEnumerable<Applications>> GetApplicationsByUserName(string userName);
        Task<List<Applications>> GetAllApplications();
        Applications AddApplications(Applications application);
        Task<IEnumerable<Applications>> GetApplicationsByGroup(string userName, string groupName);
    }
}
