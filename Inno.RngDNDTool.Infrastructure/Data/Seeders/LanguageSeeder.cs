using Inno.RngDNDTool.Core.Entities.DndEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class LanguageSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            var langList = new List<Language>
            {
                new Language
                {
                    Id = Guid.Parse("D382A917-C2A4-48A6-9529-81B24AAE44A1"),
                    Name = "Grung",
                    Description = "You can speak, read, and write Grung."
                },
                new Language
                {
                    Id = Guid.Parse("D0D5EE32-2BE6-4E23-AD46-62AF79029E27"),
                    Name = "Common Tongue",
                    Description = "You can speak, read, and write Common Tongue"
                }
            };

            builder.Entity<Language>().HasData(langList);
        }
    }
}
