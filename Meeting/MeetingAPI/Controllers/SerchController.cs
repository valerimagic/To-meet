using DTO.EnterObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerchController : ControllerBase
    {
        [HttpPost("SearchMyFriend")]
        public void SearchMyFriend(EnterObjectINFoamtion model)
        { 
            
        }
    }
}
