using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class AbilitySeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var abilityList = new List<Abilities>
            {
                new Abilities
                {
                    Id = Guid.Parse("872F8B39-F29F-4E2E-BA7F-38A03EF6BEB0"),
                    Name = "Unarmored Defense",
                    Description = "Beginning at 1st level, while you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.",
                    RequiredLevel = 0
                },
                new Abilities
                {
                    Id = Guid.Parse("2FD61669-DA9A-4E7F-9526-4BA764D8DCC5"),
                    Name = "Martial Arts",
                    Description = "At 1st level, your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons, which are shortswords and any simple melee weapons that don’t have the two-handed or heavy property.You gain the following benefits while you are unarmed or wielding only monk weapons and you aren’t wearing armor or wielding a shield: You can use Dexterity instead of Strength for the attack and damage rolls of your unarmed strikes and monk weapons. You can roll a d4 in place of the normal damage of your unarmed strike or monk weapon.This die changes as you gain monk levels, as shown in the Martial Arts column of the Monk table. When you use the Attack action with an unarmed strike or a monk weapon on your turn, you can make one unarmed strike as a bonus action.For example, if you take the Attack action and attack with a quarterstaff, you can also make an unarmed strike as a bonus action, assuming you haven’t already taken a bonus action this turn.",
                    RequiredLevel = 1
                }
            };

            builder.Entity<Abilities>().HasData(abilityList);
        }
    }
}
