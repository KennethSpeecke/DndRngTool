using Inno.RngDNDTool.Core.DtoModels.External.Scroll;
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
    public class ScrollService : IScrollService
    {
        private readonly IScrollRepository _scrollRepository;

        public ScrollService(IScrollRepository scrollRepository)
        {
            _scrollRepository = scrollRepository;
        }

        public async Task SyncScrollFromExtrernalSource(string sourceUrl)
        {
            WebRequestHelper<BaseScrollDTO> webRequestHelper = new WebRequestHelper<BaseScrollDTO>();
            var result = await webRequestHelper.GetAsync(sourceUrl + "/api/equipment-categories/scroll");
            var mapHelper = new ExternalMapper();
            var returnList = new List<Scroll>();

            foreach (var item in result.Scrolls)
            {
                var client = new HttpClient();
                var details = await client.GetAsync(sourceUrl + item.Url);
                var content = await details.Content.ReadAsStreamAsync();
                var scrollObject = await JsonSerializer.DeserializeAsync<ScrollDTO>(content);
                var newItem = await mapHelper.MapScrollObjectFromExternalSource(scrollObject);
                returnList.Add(newItem);
            }

            await _scrollRepository.AddCollectionAsync(returnList);
        }
    }
}
