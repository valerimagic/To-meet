using DAL.Contexts;
using DAL.Entiti;
using DTO.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servise.Logins
{
    public class RegistrationServise
    {
        private LoginServise _servise;

        public RegistrationServise()
        {
            _servise = new LoginServise();
        }

        public bool RegistrateUser(RegistrationDTO model)
        {
            if (!_servise.CheckUser(model))
            {
                // podgotovka na informa
                Login loginModel = new Login()
                {
                    UserName = model.UserName,
                    Password = model.Password
                };
                Registration regist = new Registration()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };
                User user = new User() {
                    Name = model.FirstName,
                    Email = model.Email,
                    Age = model.Age,
                    City = model.City,
                    Gender = model.Gender,
                    Relationship = model.Relationship
                };

                // vyvexdane v bazata
                Context _context = new Context();
                _context.Logins.Add(loginModel);
                _context.Registrations.Add(regist);
                _context.Users.Add(user);
                _context.SaveChanges();
                // vry]ane na infomaciq kym potrebitelq
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
