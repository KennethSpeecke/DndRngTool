using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class RaceLanguageSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var collection = new List<RacesLanguages> 
            {
                new RacesLanguages
                {
                    LanguageId = Guid.Parse("D382A917-C2A4-48A6-9529-81B24AAE44A1"), //Grung
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F") //Grung
                },
                new RacesLanguages
                {
                    LanguageId = Guid.Parse("D0D5EE32-2BE6-4E23-AD46-62AF79029E27"), //Grung
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F") //Grung
                },
            };

            builder.Entity<RacesLanguages>().HasData(collection);
        }
    }
}
