using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Items
{
    public class ScrollDTO : BaseItemDTO
    {
        [JsonPropertyName("requiredDifficultyClass")]
        public int RequiredDifficultyClass { get; set; }
        [JsonPropertyName("spellId")]
        public Guid SpellId { get; set; }
        [JsonPropertyName("isConsumed")]
        public bool? IsConsumed { get; set; }

    }
}
