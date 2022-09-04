using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Items
{
    public class WeaponDTO : BaseItemDTO
    {
        [JsonPropertyName("damageDice")]
        public int DamageDice { get; set; }
        [JsonPropertyName("damageType")]
        public string DamageType { get; set; }
        [JsonPropertyName("weaponType")]
        public string WeaponType { get; set; }
        [JsonPropertyName("range")]
        public int Range { get; set; }
        [JsonPropertyName("isEquiped")]
        public bool? IsEquiped { get; set; }
    }
}
