using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IScrollRepository
    {
        Task GetAsync();
        Task GetByIdAsync(Guid id);
        Task AddAsync(Scroll scroll);
        Task AddCollectionAsync(ICollection<Scroll> scrolls);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Scroll scroll);
    }
}
