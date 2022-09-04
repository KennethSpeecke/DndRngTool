using Inno.RngDNDTool.Core.Entities.DndEntities;
using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Microsoft.EntityFrameworkCore;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharacterClassSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var classesList = new List<CharacterClass> 
            {
                new CharacterClass
                {
                    Id = Guid.Parse("776C058D-0AA4-4051-A9D9-18438B4A3523"),
                    WeaponProficiencies = WeaponTypes.SimpleMeleeWeapons,
                    ArmorProficiencies = ArmorTypes.Light,
                    Name = "Monk",
                    HitDice = 8,
                    HitPoints = 8,
                    Description = "Whatever their discipline, monks are united in their ability to magically harness the energy that flows in their bodies. Whether channeled as a striking display of combat prowess or a subtler focus of defensive ability and speed, this energy infuses all that a monk does.",
                }
            };

            builder.Entity<CharacterClass>().HasData(classesList);
        }
    }
}
