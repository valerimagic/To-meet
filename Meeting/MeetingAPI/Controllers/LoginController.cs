using DTO.Convert;
using DTO.Convert.LineChart;
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

        //[HttpGet("Donut")]
        //public Donut Donut()
        //{
        //    List<int> numbers = new List<int>();
        //    numbers.Add(25);

        //    List<string> donut = new List<string>();
        //    donut.Add("first");

        //    return new Donut(50, true, true, numbers, donut);
        //}


        [HttpGet("Stepline")]
        public Stepline Stepline()
        {
            List<int> number = new List<int>() { 34, 44, 54, 21, 12, 43, 33, 23, 66, 66, 58 };

            return new Stepline(350, number);
        }

    }
}
