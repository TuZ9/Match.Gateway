using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Suitability.Gateway.Domain.Interfaces.Services;

namespace Suitability.Gateway.Api.Controllers
{
    [ApiController]
    [EnableCors("All")]
    public class QuestionController : ControllerBase
    {
        private readonly IGatewayService _gatService;
        public QuestionController(IGatewayService gatService)
        {
            _gatService = gatService;
        }

        [Route("health")]
        [HttpGet]
        public async Task<IActionResult> GetHealth()
        {
            return Ok(new[] { "Gateway Service Health Sucess" });
        }

        [Route("ConsumeProducts")]
        [HttpGet]
        public async Task<IActionResult> Gettest()
        {
            await _gatService.ConsumeProducts();

            return Ok(new[] { "Gateway Service Health Sucess" });
        }
    }
}
