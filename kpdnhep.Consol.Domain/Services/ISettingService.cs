using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Services
{
   public interface ISettingService
    {
        EditProfileConfiguration SetEditProfileSettings(EditProfileConfiguration editProfileConfiguration);
        bool GetEditProfileSettings();
    }
}
