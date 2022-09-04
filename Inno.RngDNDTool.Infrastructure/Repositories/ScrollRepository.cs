using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Repositories
{
    public class ScrollRepository : IScrollRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ScrollRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(Scroll scroll)
        {
            await _applicationDbContext.AddAsync(scroll);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddCollectionAsync(ICollection<Scroll> scrolls)
        {
            await _applicationDbContext.AddRangeAsync(scrolls);
            await _applicationDbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Scroll scroll)
        {
            throw new NotImplementedException();
        }
    }
}
