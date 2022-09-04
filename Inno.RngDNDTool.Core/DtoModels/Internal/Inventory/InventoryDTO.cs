using Inno.RngDNDTool.Core.DtoModels.External;
using Inno.RngDNDTool.Core.DtoModels.Internal.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Inventory
{
    public class InventoryDTO
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("characterId")]
        public Guid CharacterId { get; set; }
        [JsonPropertyName("potions")]
        public ICollection<PotionDTO> Potions { get; set; }
        [JsonPropertyName("foods")]
        public ICollection<FoodDTO> Foods { get; set; }
        [JsonPropertyName("weapons")]
        public ICollection<WeaponDTO> Weapons { get; set; }
        [JsonPropertyName("scrolls")]
        public ICollection<ScrollDTO> Scrolls { get; set; }
        [JsonPropertyName("armors")]
        public ICollection<ArmorDTO> Armors { get; set; }
        [JsonPropertyName("platinumPieces")]
        public int PlatinumPieces { get; set; }
        [JsonPropertyName("goldPieces")]
        public int GoldPieces { get; set; }
        [JsonPropertyName("electrumPieces")]
        public int ElectrumPieces { get; set; }
        [JsonPropertyName("silverPieces")]
        public int SilverPieces { get; set; }
        [JsonPropertyName("copperPieces")]
        public int CopperPieces { get; set; }
    }
}
