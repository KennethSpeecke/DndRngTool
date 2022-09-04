using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IFoodRepository
    {
        Task GetAsync();
        Task GetByIdAsync(Guid id);
        Task AddAsync(Food food);
        Task AddCollectionAsync(ICollection<Food> foods);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Food foods);
    }
}
