using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Services
{
   public interface IAssignApplicationService
    {
        AssignApplication GetUserAssignedApplications(AssignApplication assignApplication);
        AssignApplication AssignApplicationsToUser(AssignApplication assignApplication);
    }
}
