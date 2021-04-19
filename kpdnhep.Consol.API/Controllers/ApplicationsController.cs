using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.API.Controllers
{
    
    [ApiController]
    [Route("api/v1/Application")]
    public class ApplicationsController : ControllerBase
    {
        private readonly IApplicationService _applicationService;
         public ApplicationsController(IApplicationService applicationService)
         {
            _applicationService = applicationService;
         }
        
        /// <summary>
        /// To get all applications
        /// </summary>
        /// <returns>List of allpications</returns>
        [Route("GetAllApplications")]
        [HttpGet]
        public async Task<List<Applications>> GetAllApplications()
        {
            return await _applicationService.GetAllApplications();
        }
       
        /// <summary>
        /// To add a new application
        /// </summary>
        /// <param name="application"></param>
        /// <returns>string</returns>
        [Route("AddApplication")]
        [HttpPost]
        public Applications AddApplication(Applications application)
        {
            return _applicationService.AddApplications(application);
        }

        /// <summary>
        /// Fetches assigned application list to user
        /// </summary>
        /// <param name="username"></param>
        /// <returns>List of allpications</returns>
        [Route("GetUserApplications/{userName}")]
        [HttpGet]
        public async Task<IEnumerable<Applications>> GetUserApplications(string userName)
        {
            return await _applicationService.GetApplicationsByUserName(userName);
        }

        /// <summary>
        /// Get all applications by group
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="groupName"></param>
        /// <returns>List of applications</returns>
        [Route("GetApplicationsByGroup/{userName},{groupName}")]
        [HttpGet]
        public async Task<IEnumerable<Applications>> GetApplicationsByGroup(string userName, string groupName)
        {
            return await _applicationService.GetApplicationsByGroup(userName, groupName);
        }

    }
}
