using Inno.RngDNDTool.Core.DtoModels.Internal.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Races
{
    public class RaceDTO : BaseDTO
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("allignment")]
        public string Allignment { get; set; }
        [JsonPropertyName("traits")]
        public ICollection<TraitDTO> Traits { get; set; }
        [JsonPropertyName("languages")]
        public ICollection<LanguageDTO> Languages { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
