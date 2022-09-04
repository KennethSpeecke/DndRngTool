using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class ApplicationUsersRolesSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var collection = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                    UserId = "faa97b2c-8771-4aea-b899-e560fd892455"
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(collection);
        }
    }
}