using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Scroll
{
    public class ScrollDTO
    {
        [JsonPropertyName("desc")]
        public string[] Descriptions { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("rarity")]
        public RarityDTO Rarity { get; set; }
    }
}
