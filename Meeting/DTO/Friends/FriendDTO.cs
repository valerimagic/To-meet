using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Friends
{
    public class FriendDTO
    {
        public int ID_USER { get; set; }
        public List<int> list_of_friends { get; set; }
        public FriendDTO()
        {
            list_of_friends = new List<int>();
        }

    }
}
