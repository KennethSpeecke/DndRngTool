using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Weapon
{
    public class BaseWeaponDTO
    {
        [JsonPropertyName("equipment")]
        public ICollection<WeaponDTO> Equipment { get; set; }
    }
}
