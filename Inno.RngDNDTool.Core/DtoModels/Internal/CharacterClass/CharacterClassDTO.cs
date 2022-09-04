using Inno.RngDNDTool.Core.DtoModels.Internal.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.CharacterClass
{
    public class CharacterClassDTO : BaseDTO
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("hitDice")]
        public int HitDice { get; set; }
        [JsonPropertyName("hitPoints")]
        public int HitPoints { get; set; }
        [JsonPropertyName("armorProficiencies")]
        public string ArmorProficiencies { get; set; }
        [JsonPropertyName("weaponProficiencies")]
        public string WeaponProficiencies { get; set; }
        [JsonPropertyName("abilities")]
        public ICollection<AbilityDTO> Abilities { get; set; }
        [JsonPropertyName("classTraits")]
        public ICollection<TraitDTO> ClassTraits { get; set; }
        [JsonPropertyName("classLanguages")]
        public ICollection<LanguageDTO> ClassLanguages { get; set; }
    }
}
