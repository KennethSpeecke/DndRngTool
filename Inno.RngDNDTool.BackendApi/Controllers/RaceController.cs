using Inno.RngDNDTool.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inno.RngDNDTool.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService _raceService;

        public RaceController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _raceService.Get();
            return Ok(new { result = result });
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _raceService.GetById(id);
            return Ok(result);
        }
    }
}