using Inno.RngDNDTool.Core.DtoModels.External.Weapon;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using Inno.RngDNDTool.Core.Helpers;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Core.Mapping.External;
using Inno.RngDNDTool.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Implementations
{
    public class WeaponService : IWeaponService
    {
        private readonly IWeaponRepository _weaponRepository;

        public WeaponService(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }

        public async Task SyncWeaponsFromExternalSource(string sourceUrl)
        {
            WebRequestHelper<BaseWeaponDTO> webRequestHelper = new WebRequestHelper<BaseWeaponDTO>();
            var result = await webRequestHelper.GetAsync(sourceUrl + "/api/equipment-categories/weapon");
            var mappingHelper = new ExternalMapper();
            var returnList = new List<Weapon>();

            foreach (var item in result.Equipment)
            {
                var client = new HttpClient();
                var details = await client.GetAsync(sourceUrl + item.Url);
                var content = await details.Content.ReadAsStreamAsync();
                var weaponObject = await JsonSerializer.DeserializeAsync<WeaponDTO>(content);
                var newItem = await mappingHelper.MapWeaponObjectFromExternalSource(weaponObject);
                returnList.Add(newItem);
            }
            await _weaponRepository.AddCollectionAsync(returnList);
        }
    }
}
