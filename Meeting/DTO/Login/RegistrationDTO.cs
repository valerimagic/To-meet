﻿namespace DTO.Login
{
    public class RegistrationDTO : LoginDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
    }
}
