using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class RaceSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var classesList = new List<Race> 
            {
                new Race
                {
                    Id = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"),
                    Name = "Grung",
                    Description = "Grungs are aggressive froglike humanoids found in rain forests and tropical jungles. They are fiercely territorial and see themselves as superior to most other creatures.Grung society is a caste system. Each caste lays eggs in a separate hatching pool, and juvenile grungs join their caste upon emergence from the hatchery. All grungs are a dull greenish gray when they are born, but each individual takes on the color of its caste as it grows to adulthood. From lowest to highest caste, grungs can be green, blue, purple, red, orange, or gold.",
                    Allignment = "Alignment. Most grungs are lawful, having been raised in a strict caste system. They tend toward evil as well, coming from a culture where social advancement occurs rarely, and most often because another member of your army has died and there is no one else of that caste to fill the vacancy.",
                    
                }
            };

            builder.Entity<Race>().HasData(classesList);
        }
    }
}
