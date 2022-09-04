using AutoMapper;
using Inno.RngDNDTool.Core.DtoModels.Internal.Character;
using Inno.RngDNDTool.Core.DtoModels.Internal.Inventory;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Inno.RngDNDTool.BackendApi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IInventoryService _inventoryService;
        private readonly IMapper _mapper;

        public InventoryController(IInventoryService inventoryService, ICharacterService characterService, IMapper mapper)
        {
            _inventoryService = inventoryService;
            _characterService = characterService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                var request = ControllerContext.HttpContext.Request;
                var stream = new StreamReader(request.Body);
                var body = await stream.ReadToEndAsync();
                var content = JsonSerializer.Deserialize<InventoryDTO>(body.ToString());
                var mappedResult = _mapper.Map<Inventory>(content);
                var result = await _inventoryService.UpdateInventory(mappedResult);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(new { message = ex.Message });
            }

        }
    }
}