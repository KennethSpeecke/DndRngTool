using Inno.RngDNDTool.Core.DtoModels.External.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
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
    public class ArmorService : IArmorService
    {
        private readonly IArmorRepository _armorRepository;

        public ArmorService(IArmorRepository armorRepository)
        {
            _armorRepository = armorRepository;
        }

        public async Task SyncArmorFromExtrernalSource(string sourceUrl)
        {
            WebRequestHelper<BaseArmorDTO> _webRequestHelper = new WebRequestHelper<BaseArmorDTO>();
            var result = await _webRequestHelper.GetAsync(sourceUrl + "/api/equipment-categories/armor");
            var mappingHelper = new ExternalMapper();
            var returnList = new List<Armor>();

            foreach (var item in result.Equipment)
            {
                var client = new HttpClient();
                var details = await client.GetAsync(sourceUrl + item.Url);
                var content = await details.Content.ReadAsStreamAsync();
                var armorObject = await JsonSerializer.DeserializeAsync<ArmorDTO>(content);
                var newItem = await mappingHelper.MapArmorObjectFromExternalSource(armorObject);
                returnList.Add(newItem);
            }
            await _armorRepository.AddCollection(returnList);
        }
    }
}
