using Inno.RngDNDTool.Core.DtoModels.External.Potion;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
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
    public class PotionService : IPotionService
    {
        private readonly IPotionRepository _potionRepository;

        public PotionService(IPotionRepository potionRepository)
        {
            _potionRepository = potionRepository;
        }

        public async Task SyncPotionsFromExtrernalSource(string sourceUrl)
        {
            WebRequestHelper<BasePotionDTO> _webRequestHelper = new WebRequestHelper<BasePotionDTO>();
            var result = await _webRequestHelper.GetAsync(sourceUrl + "/api/equipment-categories/potion");
            var mappingHelper = new ExternalMapper();
            var returnList = new List<Potion>();

            foreach (var item in result.Equipment)
            {
                var client = new HttpClient();
                var details = await client.GetAsync(sourceUrl + item.Url);
                var content = await details.Content.ReadAsStreamAsync();
                var potionObject = await JsonSerializer.DeserializeAsync<PotionDTO>(content);
                var newItem = await mappingHelper.MapPotionObjectFromExternalSource(potionObject);
                returnList.Add(newItem);
            }
            await _potionRepository.AddCollectionAsync(returnList);
        }
    }
}
