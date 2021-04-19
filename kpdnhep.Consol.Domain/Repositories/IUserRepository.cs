using KPDNHEP.Console.Domain.Models;

namespace KPDNHEP.Console.Domain.Repositories
{
    public interface IUserRepository
    {
        UserAuthentication UserLogin(UserAuthentication userAuthentication);
    }
}
