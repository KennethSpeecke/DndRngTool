using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Repositories
{
    public class SpellRepository : ISpellRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SpellRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Add(BaseSpell baseSpell)
        {
            await _applicationDbContext.AddAsync(baseSpell);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddCollection(List<BaseSpell> baseSpells)
        {
            await _applicationDbContext.AddRangeAsync(baseSpells);
            await _applicationDbContext.SaveChangesAsync();
        }

        public Task Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Get()
        {
            throw new NotImplementedException();
        }

        public Task GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(BaseSpell baseSpell)
        {
            throw new NotImplementedException();
        }
    }
}
