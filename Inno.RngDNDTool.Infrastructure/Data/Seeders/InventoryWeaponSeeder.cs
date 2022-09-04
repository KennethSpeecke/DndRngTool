using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class InventoryWeaponSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var weaponsList = new List<InventoryWeapons> 
            {
                new InventoryWeapons
                {
                    InventoryId = Guid.Parse("82b556d3-ecef-40d6-aaae-12bcf93592d2"), //Copuul's inventory
                    WeaponId = Guid.Parse("8ECD50D4-9079-4428-9EC5-F45B5ABCE6C7") //Dagger
                }
            };

            builder.Entity<InventoryWeapons>()
                .HasData(weaponsList);
        }
    }
}
