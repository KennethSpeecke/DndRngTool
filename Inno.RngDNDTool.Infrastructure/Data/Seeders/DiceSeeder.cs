using Inno.RngDNDTool.Core.Entities.DndEntities.Dices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class DiceSeeder
    {
        public static ICollection<BaseDice> baseDices = new List<BaseDice> 
        {
            new BaseDice(1, 4)
            {
                Id = Guid.NewGuid()
            },
            new BaseDice(1, 6)
            {
                Id = Guid.NewGuid()
            },
            new BaseDice(1, 8)
            {
                Id = Guid.NewGuid()
            },
            new BaseDice(1, 10)
            {
                Id = Guid.NewGuid()
            },
            new BaseDice(1, 12)
            {
                Id = Guid.NewGuid()
            },
            new BaseDice(1, 20)
            {
                Id = Guid.NewGuid()
            }
        };
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<BaseDice>().HasData(baseDices);
        }

        public static BaseDice GetDiceBySides(int amountOfSides)
        {
            var result = new BaseDice(0, 0);
            foreach (var dice in baseDices)
            {
                if (dice.MaxValue == amountOfSides)
                {
                    result = dice;
                }
            }
            return result;
        }

        public static BaseDice GetById(Guid id) 
        {
            var result = new BaseDice(0, 0);
            foreach (var dice in baseDices)
            {
                if (dice.Id == id)
                {
                    result = dice;
                }
            }
            return result;
        }
    }
}
