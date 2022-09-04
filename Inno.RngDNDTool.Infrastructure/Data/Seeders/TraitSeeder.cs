using Inno.RngDNDTool.Core.Entities.DndEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class TraitSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var traitList = new List<Trait>
            {
                new Trait
                {
                    Id = Guid.Parse("F3311AF6-7B91-4071-B88A-B71C7758217D"),
                    Description = "Three traditions of monastic pursuit are common in the monasteries scattered across the multiverse. Most monasteries practice one tradition exclusively, but a few honor the three traditions and instruct each monk according to his or her aptitude and interest. All three traditions rely on the same basic techniques, diverging as the student grows more adept. Thus, a monk need choose a tradition only upon reaching 3rd level.",
                    Name = "Monastic Traditions"
                },
                new Trait
                {
                    Id = Guid.Parse("D6D14BA3-D038-4322-9296-E9B5A4DCFD5C"),
                    Name = "Age Grung",
                    Description = "Grungs mature to adulthood in a single year, but have been known to live up to 50 years."
                },
                new Trait
                {
                    Id = Guid.Parse("184BC475-D47D-4E0F-A467-771298B01C68"),
                    Name = "Size Grung",
                    Description = "Grungs stand between 2 ½ and 3 ½ feet tall and average about 30 pounds. Your size is Small."
                },
                new Trait 
                {
                    Id = Guid.Parse("C47F9F76-D53D-4FCA-95DD-6C41CD1676F8"),
                    Name = "Amphibious",
                    Description = "You can breathe air and water."
                },
                new Trait
                {
                    Id = Guid.Parse("E0FC2D4D-127C-49BF-A170-CA3290D90EEF"),
                    Name = "Poison Immunity",
                    Description = "You are immune to poison damage and the poisoned condition."
                },
                new Trait
                {
                    Id = Guid.Parse("0E1CA1B6-02E8-4C99-9E96-0C4C8FBA046A"),
                    Name = "Arboreal Alertness",
                    Description = "You have proficiency in the Perception skill."
                },
                new Trait
                {
                    Id = Guid.Parse("BA06C2E8-2F32-48BA-BD1E-32C625ECD3D3"),
                    Name = "Poisonous Skin",
                    Description = "Any creature that grapples you or otherwise comes into direct contact with your skin must succeed on a DC 12 Constitution saving throw or become poisoned for 1 minute. A poisoned creature no longer in direct contact with you can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.You can also apply this poison to any piercing weapon as part of an attack with that weapon, though when you hit the poison reacts differently. The target must succeed on a DC 12 Constitution saving throw or take 2d4 poison damage."
                },
                new Trait
                {
                    Id = Guid.Parse("18D497DD-927A-4896-8844-0788118B818B"),
                    Name = "Standing Leap",
                    Description = "Your long jump is up to 25 feet and your high jump is up to 15 feet, with or without a running start."
                },
                new Trait
                {
                    Id = Guid.Parse("5256AB96-926D-4F40-A1FE-CC33660042C3"),
                    Name = "Ability Score Increase",
                    Description = "Your Dexterity score increases by 2 and your Constitution score increases by 1."
                },
                new Trait
                {
                    Id = Guid.Parse("CB0B5963-CF5F-41E8-92DF-9DEE989009E2"),
                    Name = "Water Dependency",
                    Description = "If you fail to immerse yourself in water for at least 1 hour during a day, you suffer 1 level of exhaustion at the end of that day. You can recover from this exhaustion only through magic or by immersing yourself in water for at least 1 hour."
                },
            };

            builder.Entity<Trait>().HasData(traitList);
        }
    }
}
