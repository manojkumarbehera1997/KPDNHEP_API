using Dapper;
using KPDNHEP.Console.Domain.Repositories;
using System;
using static System.Data.CommandType;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using KPDNHEP.Console.Domain.Models;

namespace KPDNHEP.Console.Data.Repositories
{
    public class SettingRepository : BaseRepository, ISettingRepository
    {
        public EditProfileConfiguration SetEditProfile(EditProfileConfiguration editProfileConfiguration)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SettingsValue", editProfileConfiguration.Settings);
            SqlMapper.Query<string>(connectionstring, "set_edit_profile_settings", parameters, commandType: StoredProcedure).FirstOrDefault();
            return editProfileConfiguration;
        }
        public bool GetEditProfile()
        {
            DynamicParameters parameters = new DynamicParameters();
            var Permission = SqlMapper.QuerySingle<bool>(connectionstring, "get_edit_profile_settings", parameters, commandType: StoredProcedure);
            return Permission;
        }
    }
}
