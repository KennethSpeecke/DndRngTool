using Inno.RngDNDTool.BackendApi.Models.Management;
using Inno.RngDNDTool.BackendApi.ResourceModels.ResourceParameters;
using Inno.RngDNDTool.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inno.RngDNDTool.BackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagementController : ControllerBase
    {
        private readonly ISpellService _spellService;
        private readonly IArmorService _armorService;
        private readonly IPotionService _potionService;
        private readonly IWeaponService _weaponService;
        private readonly IScrollService _scrollService;

        public ManagementController(
            ISpellService spellService, 
            IArmorService armorService, 
            IPotionService potionService, 
            IWeaponService weaponService, 
            IScrollService scrollService)
        {
            _spellService = spellService;
            _armorService = armorService;
            _potionService = potionService;
            _weaponService = weaponService;
            _scrollService = scrollService;
        }

        [HttpPost("SyncSpellsFromExternalSource")]
        public async Task<IActionResult> SyncItemsFromExternalSource(ManagementResourceModel managementParameters) 
        {
            try
            {
                var dnd5eApiSourceUrl = "https://www.dnd5eapi.co";
                var resultDTO = new ExternalSyncFetchVm { FetchedObjects = new List<string>()};

                if (managementParameters.FetchSpells == true)
                {
                    await _spellService.SyncSpellsFromExternalSource(dnd5eApiSourceUrl);
                    resultDTO.FetchedObjects.Add("Spells have been fetched!");
                }
                if (managementParameters.FetchArmors == true)
                {
                    await _armorService.SyncArmorFromExtrernalSource(dnd5eApiSourceUrl);
                    resultDTO.FetchedObjects.Add("Armors have been fetched!");
                }
                if (managementParameters.FetchPotions == true)
                {
                    await _potionService.SyncPotionsFromExtrernalSource(dnd5eApiSourceUrl);
                    resultDTO.FetchedObjects.Add($"Potions have been fetched! SRC:{dnd5eApiSourceUrl}");
                }
                if (managementParameters.FetchWeapons)
                {
                    await _weaponService.SyncWeaponsFromExternalSource(dnd5eApiSourceUrl);
                    resultDTO.FetchedObjects.Add($"Weapons have been fetched! SRC: {dnd5eApiSourceUrl}");
                }
                if (managementParameters.FetchScrolls)
                {
                    await _scrollService.SyncScrollFromExtrernalSource(dnd5eApiSourceUrl);
                    resultDTO.FetchedObjects.Add($"Scrolls have been fetched! SRC: {dnd5eApiSourceUrl}");
                }

                return Ok(resultDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
