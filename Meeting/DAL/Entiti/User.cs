using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entiti
{
    public class User : BaseClass
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public Login Login { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Relationship { get; set; }
    }
}
