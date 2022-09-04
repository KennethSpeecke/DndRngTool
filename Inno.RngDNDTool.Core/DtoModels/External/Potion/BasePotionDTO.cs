using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Potion
{
    public class BasePotionDTO
    {
        [JsonPropertyName("equipment")]
        public ICollection<PotionDTO> Equipment { get; set; }
    }
}
