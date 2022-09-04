using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Armor
{
    public class BaseArmorDTO
    {
        [JsonPropertyName("equipment")]
        public ICollection<ArmorDTO> Equipment { get; set; }
    }
}
