using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharacterClassesSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var collection = new List<CharactersClasses>
            {
                new CharactersClasses
                {
                    CharacterClassId = Guid.Parse("776C058D-0AA4-4051-A9D9-18438B4A3523"),
                    CharacterId = Guid.Parse("29bcd574-1436-4a71-a750-4484d10cb105")
                }
            };

            builder.Entity<CharactersClasses>().HasData(collection);
        }
    }
}
