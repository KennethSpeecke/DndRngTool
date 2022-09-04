using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External
{
    public class CostDTO
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; } = 0;
        [JsonPropertyName("unit")]
        public string Unit { get; set; } = "gp";
    }
}
