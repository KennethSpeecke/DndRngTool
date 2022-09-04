using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<Inventory> UpdateInventory(Inventory inventory);
        Task<Inventory> GetByIdAsync(Guid inventoryId);
    }
}