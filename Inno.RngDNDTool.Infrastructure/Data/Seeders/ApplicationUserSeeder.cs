using Inno.RngDNDTool.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class ApplicationUserSeeder
    {
        public static void Seed(ModelBuilder builder) {
            var hasher = new PasswordHasher<ApplicationUser>();

            var userList = new List<ApplicationUser> 
            { 
                new ApplicationUser
                {
                    Id = "faa97b2c-8771-4aea-b899-e560fd892455",
                    UserName = "RngAdmin",
                    Email = "Rng@Admin.rng",
                    FirstName = "Admin",
                    LastName = "Super",
                    EmailConfirmed = true,
                    NormalizedUserName = "RNGADMIN",
                    NormalizedEmail = "RNG@ADMIN.RNG"
                } 
            };

            foreach (var user in userList)
            {
                user.PasswordHash = hasher.HashPassword(user, "Test123?");
            }

            builder.Entity<ApplicationUser>()
                .HasData(userList);
        }
    }
}
