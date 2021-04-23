using DTO.Friends;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        [HttpPost("CreateFriend")]
        
        public bool CreateFriend(FriendDTO model)
        {
            FriendServise _servise = new FriendServise();
            return _servise.AddFrinedInList(model);
        }
   
    }
}
