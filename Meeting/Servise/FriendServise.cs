using DAL.Contexts;
using DAL.Entiti;
using DTO.Friends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servise
{
    public class FriendServise
    {
        private Context _context ;
        public FriendServise()
        {
            _context = new Context();
        }
        public bool AddFrinedInList(FriendDTO model)
        {
            foreach (var item in model.list_of_friends)
            {
                if (_context.FriendLists.Where(x => x.UserIDMy.ID == model.ID_USER && x.UserIDFriend.ID == item).Count() == 0)
                {
                    // vyvexdame infoto v entiuty model 
                    FriendList frien_relation = new FriendList()
                    {
                        UserIDMy = GetUSerByID(model.ID_USER),
                        UserIDFriend = GetUSerByID(item)
                    };
                    _context.FriendLists.Add(frien_relation);
                }

            }
            _context.SaveChanges();
            return true;
           
        }

        private User GetUSerByID(int iD_USER)
        {
            //1. YOu
            User uer = new User();
            List<User> uyser_list = _context.Users.ToList();
            foreach (var item in uyser_list)
            {
                if (item.ID == iD_USER)
                {
                    uer =  item;
                }
            }
            return uer;
            // select * form user

            //2. IVO
            //return _context.Users.Where(x => x.ID == iD_USER).First();
            // select * form user where id = {id_user};


        }




        //1. Създаване на метод
        //2. Взжимаш всички връзки между приятелите  - таблицата FriendKList
        // 3. За всяко ИД правиш заявка за всимане на Първо име и фамилиуя от таблицата Registration 

        // ЦЕЛ - да върнем на потребителя  бвсички приятелствва



    }
}
