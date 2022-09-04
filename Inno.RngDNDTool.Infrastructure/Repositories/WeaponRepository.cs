using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
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
    public class WeaponRepository : IWeaponRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public WeaponRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(Weapon weapon)
        {
            await _applicationDbContext.AddAsync(weapon);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddCollectionAsync(ICollection<Weapon> weapons)
        {
            await _applicationDbContext.AddRangeAsync(weapons);
            await _applicationDbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Weapon>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Weapon> GetByIdAsync(Guid id)
        {
            return await _applicationDbContext.Weapons.FirstOrDefaultAsync(w => w.Id == id);
        }

        public Task UpdateAsync(Weapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}
