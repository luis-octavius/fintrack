using Microsoft.AspNetCore.Mvc;

namespace FinTrackAPI.Controllers.Config
{
    [ApiController]
    [Route("config/[action]")]
    public class ConfigController(ISession session) : ControllerBase
    {
        [HttpGet]
        public OkResult GetHealth()
        {
            session.Clear();
            return Ok();
        }
    }
}
