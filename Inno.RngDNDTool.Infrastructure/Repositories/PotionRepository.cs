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
    public class PotionRepository : IPotionRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PotionRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(Potion potion)
        {
            await _applicationDbContext.AddAsync(potion);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddCollectionAsync(ICollection<Potion> potions)
        {
            await _applicationDbContext.AddRangeAsync(potions);
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

        public Task Update(Potion potion)
        {
            throw new NotImplementedException();
        }
    }
}
