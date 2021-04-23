using DTO.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servise.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        [HttpPost("Registration")]
        public bool Registration(RegistrationDTO model)
        {
            RegistrationServise _servise = new RegistrationServise();
            return _servise.RegistrateUser(model);
        }
    }
}
