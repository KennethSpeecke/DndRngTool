using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Items
{
    public class PotionDTO : BaseItemDTO
    {
        [JsonPropertyName("potionType")]
        public string PotionType { get; set; }
        [JsonPropertyName("statusEffectDurationInMinutes")]
        public int StatusEffectDurationInMinutes { get; set; }
        [JsonPropertyName("statusEffectValue")]
        public int StatusEffectValue { get; set; }
        [JsonPropertyName("isConsumed")]
        public bool? IsConsumed { get; set; }

    }
}
