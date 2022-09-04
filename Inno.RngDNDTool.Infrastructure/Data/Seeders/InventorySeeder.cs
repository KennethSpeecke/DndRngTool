using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Currencies.Coins;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class InventorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            var inventoryList = new List<Inventory> 
            {
                new Inventory
                {
                    Id = Guid.Parse("82b556d3-ecef-40d6-aaae-12bcf93592d2"),
                    CharacterId = Guid.Parse("29bcd574-1436-4a71-a750-4484d10cb105"),
                    PlatinumPieces = 0,
                    GoldPieces = 15,
                    CopperPieces = 0,
                    SilverPieces = 0,
                    ElectrumPieces = 0
                }
            };

            modelBuilder.Entity<Inventory>().HasData(inventoryList);
        }
    }
}
