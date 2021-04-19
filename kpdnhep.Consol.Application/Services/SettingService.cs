using KPDNHEP.Console.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Application.Services
{
   public class SettingService: ISettingService
    {
        private readonly ISettingRepository _permissionRepository;
        public SettingService(ISettingRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        public EditProfileConfiguration SetEditProfileSettings(EditProfileConfiguration editProfileConfiguration)
        {
            return _permissionRepository.SetEditProfile(editProfileConfiguration);
        }
        public bool GetEditProfileSettings()
        {
            return _permissionRepository.GetEditProfile();
        }
    }
   
}
