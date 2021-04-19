using KPDNHEP.Console.Domain.Models;

namespace KPDNHEP.Console.Domain.Services
{
    public interface IUserService
    {
        UserAuthentication UserLogin(UserAuthentication userGroup);
    }
}
