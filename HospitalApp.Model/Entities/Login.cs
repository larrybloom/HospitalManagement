namespace HospitalApp.Model.Entities
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Jwt { get; set; }
        public IList<string> UserRole { get; set; }
    }
}
