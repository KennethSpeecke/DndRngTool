using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharacterClassesAbilitiesSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var collection = new List<CharacterClassesAbilities> 
            {
                new CharacterClassesAbilities
                {
                    AbilityId = Guid.Parse("872F8B39-F29F-4E2E-BA7F-38A03EF6BEB0"),
                    CharacterClassId = Guid.Parse("776C058D-0AA4-4051-A9D9-18438B4A3523")
                },
                new CharacterClassesAbilities
                {
                    AbilityId = Guid.Parse("2FD61669-DA9A-4E7F-9526-4BA764D8DCC5"),
                    CharacterClassId = Guid.Parse("776C058D-0AA4-4051-A9D9-18438B4A3523")
                },

            };

            builder.Entity<CharacterClassesAbilities>().HasData(collection);
        }
    }
}
