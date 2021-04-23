using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entiti
{
    public class Registration : BaseClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public Login login { get; set; }
    }
}
