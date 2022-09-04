using Inno.RngDNDTool.Core.DtoModels.Internal.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Items
{
    public class BaseItemDTO : BaseDTO
    {
        [JsonPropertyName("buyPrice")]
        public int BuyPrice { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("itemImageUrl")]
        public string ItemImageUrl { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }
        [JsonPropertyName("sellPrice")]
        public int SellPrice { get; set; }
        [JsonPropertyName("weightInKg")]
        public double WeightInKg { get; set; }
    }
}
