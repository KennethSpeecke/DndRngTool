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
    public class FoodRepository : IFoodRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public FoodRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(Food food)
        {
            await _applicationDbContext.AddAsync(food);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddCollectionAsync(ICollection<Food> foods)
        {
            await _applicationDbContext.AddRangeAsync(foods);
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

        public Task UpdateAsync(Food foods)
        {
            throw new NotImplementedException();
        }
    }
}
