using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External
{
    public class DamageDTO
    {
        public DamageTypeDTO damage_type { get; set; }
        public DamageLevelDTO damage_at_slot_level { get; set; }
        [JsonPropertyName("damage_dice")]
        public string DamageDice { get; set; }
    }
}
