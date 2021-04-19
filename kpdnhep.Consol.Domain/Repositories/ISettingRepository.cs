using KPDNHEP.Console.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPDNHEP.Console.Domain.Repositories
{
   public interface ISettingRepository
    {
        bool GetEditProfile();
        EditProfileConfiguration SetEditProfile(EditProfileConfiguration editProfileConfiguration);
    }
}
