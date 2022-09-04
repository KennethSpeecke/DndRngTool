using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
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
    public class ArmorRepository : IArmorRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ArmorRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Add(Armor armor)
        {
            await _applicationDbContext.AddAsync(armor);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddCollection(ICollection<Armor> armor)
        {
            await _applicationDbContext.AddRangeAsync(armor);
            await _applicationDbContext.SaveChangesAsync();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Armor>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Armor> GetById(Guid id)
        {
            return await _applicationDbContext.Armors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task Update(Armor armor)
        {
            throw new NotImplementedException();
        }
    }
}