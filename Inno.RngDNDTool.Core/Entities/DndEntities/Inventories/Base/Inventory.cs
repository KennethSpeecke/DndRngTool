using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Npcs.Base;
using Inno.RngDNDTool.Core.Entities.Joins;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base
{
    public class Inventory : BaseEntity<Guid>
    {

        #region Public Properties

        public Character? Character { get; set; }
        public Guid? CharacterId { get; set; }
        public Npc? Npc { get; set; }
        public Guid? NpcId { get; set; }
        public int PlatinumPieces { get; set; }
        public int GoldPieces { get; set; }
        public int ElectrumPieces { get; set; }
        public int SilverPieces { get; set; }
        public int CopperPieces { get; set; }
        public ICollection<InventoryPotions> InventoryPotions { get; set; }
        public ICollection<InventoryArmors> InventoryArmors { get; set; }
        public ICollection<InventoryFoods> InventoryFoods { get; set; }
        public ICollection<InventoryScrolls> InventoryScrolls { get; set; }
        public ICollection<InventoryWeapons> InventoryWeapons { get; set; }

        #endregion Public Properties

        public Inventory()
        {

        }
        public Inventory(bool isNewCharacter)
        {
            GoldPieces = 15;
        }
    }
}