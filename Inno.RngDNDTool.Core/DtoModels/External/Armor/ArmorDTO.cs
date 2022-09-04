using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Armor
{
    public class ArmorDTO
    {
        [JsonPropertyName("desc")]
        public string[] Descriptions { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("armor_category")]
        public string ArmorCategory { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        [JsonPropertyName("stealth_disadvantage")]
        public bool StealthDisadvantage { get; set; }
        [JsonPropertyName("armor_class")]
        public ArmorClassDTO ArmorClass { get; set; }
        [JsonPropertyName("cost")]
        public ArmorCostDTO Costs { get; set; }
        [JsonPropertyName("rarity")]
        public RarityDTO Rarity { get; set; }
    }
}
