using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Implementations
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> GetByIdAsync(Guid inventoryId)
        {
            var result = await _inventoryRepository.GetById(inventoryId);
            return result;
        }

        public async Task<Inventory> UpdateInventory(Inventory inventory)
        {
            
            var result = await _inventoryRepository.UpdateInventory(inventory);
            return result;
        }
    }
}