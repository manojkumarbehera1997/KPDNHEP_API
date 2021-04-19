using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Application.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<IEnumerable<Applications>> GetApplicationsByUserName(string userName)
        {
            return await _applicationRepository.GetAssignedApplicationsToUser(userName);
        }
        public async Task<List<Applications>> GetAllApplications()
        {
            return await _applicationRepository.GetAllApplications();
        }
        public Applications AddApplications(Applications applications)
        {
            return _applicationRepository.AddApplication(applications);
        }
        public async Task<IEnumerable<Applications>> GetApplicationsByGroup(string UserName, string GroupName)
        {
            return await _applicationRepository.GetApplicationsByGroup(UserName, GroupName);
        }
    }
}
