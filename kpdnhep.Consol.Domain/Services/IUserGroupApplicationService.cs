using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPDNHEP.Console.Domain.Services
{
    public interface IUserGroupApplicationService
    {
        UserGroupApplication AssignApplicationToGroup(UserGroupApplication userGroupApplication);
    }
}
