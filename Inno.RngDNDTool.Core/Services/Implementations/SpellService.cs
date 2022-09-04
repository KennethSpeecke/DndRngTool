using Inno.RngDNDTool.Core.DtoModels.External;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
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
    public class SpellService : ISpellService
    {
        private readonly ISpellRepository _spellRepository;
        public SpellService(ISpellRepository spellRepository)
        {
            _spellRepository = spellRepository;
        }
        public async Task SyncSpellsFromExternalSource(string sourceUrl)
        {
            WebRequestHelper<BaseSpellDTO> _webRequestHelper = new WebRequestHelper<BaseSpellDTO>();
            var result = await _webRequestHelper.GetAsync(sourceUrl + "/api/spells");
            var mappingHelper = new ExternalMapper();

            var resultList = new List<BaseSpell>();

            foreach (var item in result.results)
            {
                var client = new HttpClient();
                var details = await client.GetAsync(sourceUrl + item.url);
                var content = await details.Content.ReadAsStreamAsync();
                var spellObject = await JsonSerializer.DeserializeAsync<SpellDTO>(content);
                var newItem = await mappingHelper.MapSpellObjectFromExternalSource(spellObject);
                DamageTypes damageType;
                if (spellObject.damage.damage_type == null)
                {
                    spellObject.damage.damage_type = new DamageTypeDTO { name = "none", url = "none" };
                }
                if (Enum.TryParse(spellObject.damage.damage_type.name, out damageType))
                {
                    newItem.DamageType = damageType;
                }

                resultList.Add(newItem);
            }
            await _spellRepository.AddCollection(resultList);
        }
    }
}
