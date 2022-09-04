using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharactersRacesSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var seedCollection = new List<CharacterRaces>
            {
                new CharacterRaces
                {
                    CharacterId = Guid.Parse("29bcd574-1436-4a71-a750-4484d10cb105"),
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F")
                }
            };

            builder.Entity<CharacterRaces>().HasData(seedCollection);
        }
    }
}
