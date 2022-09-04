using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
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
    public class CharacterClassRepository : ICharacterClassRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CharacterClassRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<CharacterClass>> Get()
        {
            var result = await _dbContext.CharacterClasses
                .Include(x => x.CharacterClassesTraits)
                    .ThenInclude(xa => xa.Trait)
                .Include(x => x.CharacterClassesAbilities)
                    .ThenInclude(xa => xa.Ability)
                .Include(x => x.CharacterClassLanguages)
                    .ThenInclude(xa => xa.Language)
                        .ToListAsync();
            return result;
        }

        public async Task<CharacterClass> GetById(Guid characterClassId)
        {
            var result = await _dbContext.CharacterClasses.Where(x => x.Id == characterClassId)
                .Include(x => x.CharacterClassesTraits)
                    .ThenInclude(xa => xa.Trait)
                .Include(x => x.CharacterClassesAbilities)
                    .ThenInclude(xa => xa.Ability)
                .Include(x => x.CharacterClassLanguages)
                    .ThenInclude(xa => xa.Language)
                        .FirstOrDefaultAsync();
            return result;
        }
    }
}