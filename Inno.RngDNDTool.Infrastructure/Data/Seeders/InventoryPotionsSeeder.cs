using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class InventoryPotionsSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var potionList = new List<InventoryPotions>
            {
                new InventoryPotions
                {
                    InventoryId = Guid.Parse("82b556d3-ecef-40d6-aaae-12bcf93592d2"), //Copuul
                    PotionId = Guid.Parse("B9F5C577-D2F8-4C39-ADE1-BA5F33684DCA") //Potion Of Healing
                }
            };

            builder.Entity<InventoryPotions>()
                .HasData(potionList);
        }
    }
}
