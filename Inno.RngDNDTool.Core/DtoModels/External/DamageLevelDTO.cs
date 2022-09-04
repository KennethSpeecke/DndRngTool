using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External
{
    public class DamageLevelDTO
    {
        public string None { get; set; } = "0";
        [JsonPropertyName("2")]
        public string Two { get; set; } = "2";
    }
}
