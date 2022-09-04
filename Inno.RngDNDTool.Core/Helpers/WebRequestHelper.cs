using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Helpers
{
    public class WebRequestHelper<DTOType>
    {
        private readonly HttpClient _httpClient;

        public WebRequestHelper()
        {
            _httpClient = new HttpClient();
        }

        public async Task<DTOType> GetAsync(string requestUri)
        {
            var response = await _httpClient.GetAsync(requestUri);
            var content = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<DTOType>(content);
            _httpClient.Dispose();
            return result;
        }
    }
}
