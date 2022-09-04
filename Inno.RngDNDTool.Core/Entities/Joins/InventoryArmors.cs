using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class InventoryArmors
    {
        public Armor Armor { get; set; }
        public Guid ArmorId { get; set; }
        public Inventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
        public bool? IsEquiped { get; set; }
    }
}