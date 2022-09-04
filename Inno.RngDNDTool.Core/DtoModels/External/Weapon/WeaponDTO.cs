using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Weapon
{
    public class WeaponDTO
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("desc")]
        public string[] Descriptions { get; set; }
        [JsonPropertyName("damage")]
        public DamageDTO Damage { get; set; }
        [JsonPropertyName("weight")]
        public double Weight { get; set; }
        [JsonPropertyName("cost")]
        public CostDTO Cost { get; set; }
        [JsonPropertyName("rarity")]
        public RarityDTO Rarity { get; set; }
        [JsonPropertyName("category_range")]
        public string WeaponType { get; set; }
        [JsonPropertyName("range")]
        public RangeDTO Range { get; set; }
    }
}
