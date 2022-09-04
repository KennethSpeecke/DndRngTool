using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class InventoryWeapons
    {
        public Inventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
        public bool? IsEquiped { get; set; }
        public Weapon Weapon { get; set; }
        public Guid WeaponId { get; set; }
    }
}