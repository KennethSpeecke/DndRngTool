using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class RacesTraitsSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var collection = new List<RaceTraits>
            {
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("D6D14BA3-D038-4322-9296-E9B5A4DCFD5C") //Age Grung
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("184BC475-D47D-4E0F-A467-771298B01C68") //Size Grung
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("C47F9F76-D53D-4FCA-95DD-6C41CD1676F8") //Amphibious
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("E0FC2D4D-127C-49BF-A170-CA3290D90EEF") //Poison Immunity
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("0E1CA1B6-02E8-4C99-9E96-0C4C8FBA046A") //Aboreal Alertness
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("BA06C2E8-2F32-48BA-BD1E-32C625ECD3D3") //Poisonous Skin
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("18D497DD-927A-4896-8844-0788118B818B") //Standing Leap
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("5256AB96-926D-4F40-A1FE-CC33660042C3") //Ability Score Increase
                },
                new RaceTraits
                {
                    RaceId = Guid.Parse("97398AED-9DD3-48B3-9689-9DD455DB396F"), //Grung
                    TraitId = Guid.Parse("CB0B5963-CF5F-41E8-92DF-9DEE989009E2") //Water dependency
                }
            };

            builder.Entity<RaceTraits>().HasData(collection);
        }
    }
}
