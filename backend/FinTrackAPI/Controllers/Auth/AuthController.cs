using FinTrackAPI.Data;
using FinTrackAPI.Domain.DTOs.AuthController;
using FinTrackAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinTrackAPI.Controllers.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly FinTrackDbContext _context;

        public AuthController(FinTrackDbContext context)
        {
            _context = context;
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register(AuthRegisterRequest req)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(req.Password);

            var user = new User(req.Name, req.Email, passwordHash);

            try
            {
                _context.Users.Add(user);

                await _context.SaveChangesAsync();
                return Ok();
            } catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar usuário: {ex}");
                return BadRequest();
            }
        }
    }
}
