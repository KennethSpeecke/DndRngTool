using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IPotionRepository
    {
        Task GetAsync();
        Task GetByIdAsync(Guid id);
        Task AddAsync(Potion potion);
        Task AddCollectionAsync(ICollection<Potion> potions);
        Task DeleteAsync(Guid id);
        Task Update(Potion potion);
    }
}
