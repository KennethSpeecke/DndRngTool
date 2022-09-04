using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.DtoModels.Internal.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Spells
{
    public class SpellDTO : BaseDTO
    {
        [JsonPropertyName("attackRadiusInMeters")]
        public int AttackRadiusInMeters { get; set; }

        [JsonPropertyName("castingTime")]
        public string CastingTime { get; set; }

        [JsonPropertyName("concentration")]
        public bool Concentration { get; set; }

        [JsonPropertyName("damageRoll")]
        public int DamageRoll { get; set; }

        [JsonPropertyName("damageType")]
        public string DamageType { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; } = 1;

        [JsonPropertyName("material")]
        public string Material { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("requiredSavingThrowType")]
        public string RequiredSavingThrowType { get; set; }

        [JsonPropertyName("ritual")]
        public bool Ritual { get; set; }
    }
}