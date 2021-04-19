using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.API.Controllers
{
    [ApiController]
    [Route("api/v1/AssignedApplication")]
    public class AssignApplicationController : ControllerBase
    {
        private readonly IAssignApplicationService _assignedApplicationService;
        public AssignApplicationController(IAssignApplicationService assignedApplicationService)
        {
            _assignedApplicationService = assignedApplicationService;
        }
        
        /// <summary>
        /// Fetches assigned application ids to user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [Route("GetUserAssignedApplications")]
        [HttpPost]
        public AssignApplication GetUserAssignedApplications(AssignApplication assignApplication)
        {
            return _assignedApplicationService.GetUserAssignedApplications(assignApplication);
        }

        /// <summary>
        /// Assign application to user
        /// </summary>
        /// <param name="assignedApplication"></param>
        /// <returns>int</returns>
        [Route("AssignApplicationsToUser")]
        [HttpPost]
        public AssignApplication AssignApplicationsToUser(AssignApplication assignApplication)
        {
            return _assignedApplicationService.AssignApplicationsToUser(assignApplication);
        }
    }
}
