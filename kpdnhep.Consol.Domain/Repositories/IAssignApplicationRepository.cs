using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Repositories
{
  public  interface IAssignApplicationRepository
    {
        AssignApplication GetAssignedApplicationIdsToUser(AssignApplication assignApplication);
        AssignApplication AssignApplicationsToUser(AssignApplication assignApplication);
    }
}
