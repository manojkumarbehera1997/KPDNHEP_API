using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Application.Services
{
   public class AssignApplicationService:IAssignApplicationService
    {
        private readonly IAssignApplicationRepository _assignedApplicationRepository;

        public AssignApplicationService(IAssignApplicationRepository assignedApplicationRepository)
        {
            _assignedApplicationRepository = assignedApplicationRepository;
        }
      
        public AssignApplication GetUserAssignedApplications(AssignApplication assignApplication)
        {
            return _assignedApplicationRepository.GetAssignedApplicationIdsToUser(assignApplication);
        }

        public AssignApplication AssignApplicationsToUser(AssignApplication assignApplication)
        {
            return _assignedApplicationRepository.AssignApplicationsToUser(assignApplication);
        }

    }
}
