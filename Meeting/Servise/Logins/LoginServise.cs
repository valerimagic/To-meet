using DAL.Contexts;
using DTO.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servise.Logins
{
    public class LoginServise
    {
        public bool CheckUser(LoginDTO model)
        {
            Context _context = new Context();
            if (_context.Logins.Where(x=> x.UserName.ToLower() == model.UserName.ToLower() && x.Password == model.Password).Count() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
