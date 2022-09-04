using AutoMapper;
using Inno.RngDNDTool.Core.DtoModels.Internal.Character;
using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace Inno.RngDNDTool.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;

        public CharacterController(ICharacterService characterService, IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var foundItem = await _characterService.GetByIdAsync(id);
            var mappedResult = _mapper.Map<CharacterDTO>(foundItem);
            return Ok(mappedResult);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var foundItems = await _characterService.GetAsync();
            var mappedResult = _mapper.Map<ICollection<CharacterDTO>>(foundItems);
            return Ok(mappedResult);
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                var request = ControllerContext.HttpContext.Request;
                var stream = new StreamReader(request.Body);
                var body = await stream.ReadToEndAsync();
                var content = JsonSerializer.Deserialize<CharacterDTO>(body.ToString());
                var mappedResult = _mapper.Map<Character>(content);
                await _characterService.AddAsync(mappedResult);
                return await Task.FromResult(Ok(content));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message});
            }
        }
    }
}