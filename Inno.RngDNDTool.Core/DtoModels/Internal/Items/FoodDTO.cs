using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Items
{
    public class FoodDTO : BaseItemDTO
    {
        [JsonPropertyName("foodType")]
        public string FoodType { get; set; }
        [JsonPropertyName("statusEffectDuration")]
        public int StatusEffectDuration { get; set; }
        [JsonPropertyName("statusEffectType")]
        public string StatusEffectType { get; set; }
        [JsonPropertyName("statusEffectValue")]
        public int StatusEffectValue { get; set; }
        [JsonPropertyName("isConsumed")]
        public bool? IsConsumed { get; set; }
    }
}
