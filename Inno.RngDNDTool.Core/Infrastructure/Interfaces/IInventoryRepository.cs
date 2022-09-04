using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IInventoryRepository
    {
        Task<Inventory> GetById(Guid inventoryId);
        Task<ICollection<Inventory>> Get();
        Task<Inventory> UpdateInventory(Inventory inventory);
    }
}