using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharacterClassesTraitsSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var collection = new List<CharacterClassesTraits>
            {
                new CharacterClassesTraits
                {
                    CharacterClassId = Guid.Parse("776C058D-0AA4-4051-A9D9-18438B4A3523"), //Monk
                    TraitId = Guid.Parse("F3311AF6-7B91-4071-B88A-B71C7758217D") //Monastic Traditions
                }
            };

            builder.Entity<CharacterClassesTraits>().HasData(collection);
        }
    }
}
