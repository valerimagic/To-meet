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
                if (_context.FriendLists.Where(x => x.UserIDMy == model.ID_USER && x.UserIDFriend == item).Count() == 0)
                {
                    // vyvexdame infoto v entiuty model 
                    FriendList frien_relation = new FriendList()
                    {
                        UserIDMy = model.ID_USER,
                        UserIDFriend = item
                    };
                    _context.FriendLists.Add(frien_relation);
                }
                
            }
            _context.SaveChanges();
            return true;
           
        }

        //1. Създаване на метод
        //2. Взжимаш всички връзки между приятелите  - таблицата FriendKList
        // 3. За всяко ИД правиш заявка за всимане на Първо име и фамилиуя от таблицата Registration 

        // ЦЕЛ - да върнем на потребителя  бвсички приятелствва



    }
}
