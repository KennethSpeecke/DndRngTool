using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Items
{
    public class ArmorDTO : BaseItemDTO
    {
        [JsonPropertyName("armorClass")]
        public int ArmorClass { get; set; }
        [JsonPropertyName("bodyPlacement")]
        public string BodyPlacement { get; set; }
        [JsonPropertyName("isEquiped")]
        public bool? IsEquiped { get; set; }
    }
}
