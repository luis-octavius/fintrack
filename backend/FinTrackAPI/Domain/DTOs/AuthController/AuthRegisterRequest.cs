namespace FinTrackAPI.Domain.DTOs.AuthController
{
    public class AuthRegisterRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
