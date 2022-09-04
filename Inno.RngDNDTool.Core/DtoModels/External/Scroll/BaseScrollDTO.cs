using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External.Scroll
{
    public class BaseScrollDTO
    {
        [JsonPropertyName("equipment")]
        public ICollection<ScrollDTO> Scrolls { get; set; }
    }
}
