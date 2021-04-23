using DTO.Convert;
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
    public class LoginController : ControllerBase
    {
        [HttpGet("Login")]
        public bool Login(LoginDTO model)
        {
            LoginServise _servise = new LoginServise();
            return _servise.CheckUser(model);
        }
        [HttpGet("Converts")]
        public Donut Converts()
        {
            List<string> category = new List<string>();
            category.Add("asdasdasd");

            List<int> data = new List<int>();
            data.Add(56);

            return new Donut(230 , true, false , category , data);
        }

        [HttpPost("Baisc")]
        public Basic Baisc(Object varinfo)
        {

            return new Basic();
        }

        [HttpGet("Donut")]
        public Donut Donut()
        {
            List<int> donut = new List<int>();
            donut.Add("first");

            

            return new Donut();
        }

    }
}
