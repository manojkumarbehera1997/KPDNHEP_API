using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPDNHEP.Console.Application.Services
{
    public class UserGroupApplicationService:IUserGroupApplicationService
    {
        private readonly IUserGroupApplicationRepository _userGroupApplicationRepository;
        public UserGroupApplicationService(IUserGroupApplicationRepository userGroupApplicationRepository)
        {
            _userGroupApplicationRepository = userGroupApplicationRepository;
        }
        public UserGroupApplication AssignApplicationToGroup(UserGroupApplication userGroupApplication)
        {
            return _userGroupApplicationRepository.AssignApplicationToGroup(userGroupApplication);
        }
    }
}
