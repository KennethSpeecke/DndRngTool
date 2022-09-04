using Inno.RngDNDTool.Core.DtoModels.Internal.Character;
using Inno.RngDNDTool.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inno.RngDNDTool.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterClassController : ControllerBase
    {
        private readonly ICharacterClassService _characterClassService;

        public CharacterClassController(ICharacterClassService characterClassService)
        {
            _characterClassService = characterClassService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _characterClassService.Get();
            return Ok(new { result = result});
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _characterClassService.GetById(id);
            return Ok(result);
        }
    }
}