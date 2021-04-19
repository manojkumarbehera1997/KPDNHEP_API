using KPDNHEP.Console.Domain.Models;
using KPDNHEP.Console.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.API.Controllers
{

    [ApiController]
    [Route("api/v1/Setting")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingService _settingService;
        public SettingsController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [Route("UpdateEditProfileSettings")]
        [HttpPost]
        public EditProfileConfiguration UpdateEditProfileSettings(EditProfileConfiguration editProfileConfiguration)
        {
            return _settingService.SetEditProfileSettings(editProfileConfiguration);
        }

        [Route("GetEditProfileSettings")]
        [HttpGet]
        public bool EditProfileSettings()
        {
            return _settingService.GetEditProfileSettings();
        }
    }
}
