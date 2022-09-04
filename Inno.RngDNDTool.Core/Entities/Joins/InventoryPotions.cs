﻿using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class InventoryPotions
    {
        public Inventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
        public bool? IsConsumed { get; set; }
        public Potion Potion { get; set; }
        public Guid PotionId { get; set; }
    }
}