using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Services;

namespace KPDNHEP.Console.Application.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public UserAuthentication UserLogin(UserAuthentication userGroup)
        {
            return _userRepository.UserLogin(userGroup);

        }
    }
}
