namespace DTO.Login
{
    public class RegistrationDTO : LoginDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }
    }
}
