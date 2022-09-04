using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class InventoryArmorSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var inventoryArmorsList = new List<InventoryArmors> 
            { 
                new InventoryArmors 
                {
                    ArmorId = Guid.Parse("A66F53E9-605D-4EDE-AF78-F6CC985203EF"), // Hide Arrmor
                    InventoryId = Guid.Parse("82b556d3-ecef-40d6-aaae-12bcf93592d2") //Copuul's Inventory
                } 
            };


            builder.Entity<InventoryArmors>()
                .HasData(inventoryArmorsList);
        }
    }
}
