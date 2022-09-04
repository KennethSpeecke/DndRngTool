using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public InventoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Inventory>> Get()
        {
            return await _dbContext.Inventories.ToListAsync();
        }

        public async Task<Inventory> GetById(Guid inventoryId)
        {
            var foundInventory = await _dbContext.Inventories.FirstOrDefaultAsync(x => x.Id == inventoryId);
            if (foundInventory != null)
            {
                return foundInventory;
            }
            else
            {
                return new Inventory();
            }
        }

        public async Task<Inventory> UpdateInventory(Inventory inventory)
        {
            _dbContext.Inventories.Update(inventory);
            await _dbContext.SaveChangesAsync();
            return inventory;
        }
    }
}