using Dapper;
using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Repositories;
using System.Linq;

namespace KPDNHEP.Console.Data.Repositories
{
    public class UserRepository: BaseRepository, IUserRepository
    {

        public UserAuthentication UserLogin(UserAuthentication userAuthentication)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@UserName", userAuthentication.UserName);
            dynamicParameters.Add("@Password", userAuthentication.Password);
            UserAuthentication result = SqlMapper.Query<UserAuthentication>(connectionstring, "user_login", dynamicParameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
         //  if(result!=null)
            //{
                return result;
            //}
            //else
            //{
            //    return result
            //}

        }                  
    }
}
