using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entiti
{
    public class FriendList : BaseClass
    {
        public User UserIDMy { get; set; }

        public User UserIDFriend { get; set; }
    }
}
