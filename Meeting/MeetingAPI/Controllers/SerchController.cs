using DAL.Entiti;
using DTO.EnterObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servise.Searchs;
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
        public List<User> SearchMyFriend(EnterObjectINFoamtion model)
        {
            Search _servise = new Search();
            return _servise.GetMatch(model);
        }
    }
}
