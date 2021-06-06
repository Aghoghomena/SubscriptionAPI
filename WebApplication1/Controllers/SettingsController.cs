using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domain;

namespace WebApplication1.Controllers
{

    [ApiController]
    public class SettingsController : ControllerBase
    {

        private ISettings _settings;
        public SettingsController(ISettings settings)
        {
            //this is dependency injection
            _settings = settings;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult getEmployees()
        {
            return Ok(_settings.GetSingleSetting("CountDown_Date"));
        }


    }
}
