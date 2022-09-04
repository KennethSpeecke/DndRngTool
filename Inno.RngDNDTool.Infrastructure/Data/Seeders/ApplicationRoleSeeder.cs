using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class ApplicationRoleSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                    Name = "admin",
                    NormalizedName = "ADMIN"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}