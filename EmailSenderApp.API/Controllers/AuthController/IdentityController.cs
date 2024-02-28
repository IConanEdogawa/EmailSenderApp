using EmailSenderApp.Application.Services.AuthServices;
using EmailSenderApp.Domain.Entites.Models.AuthModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailSenderApp.API.Controllers.AuthController
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IAuthService _authService;

        public IdentityController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Get(User user)
        {
            var result = _authService.GeneratingToken(user);

            return Ok(result);
        }
    }
}
