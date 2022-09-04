using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
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
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RaceRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Race>> Get()
        {
            return await _dbContext.Races
                .Include(x => x.RacesLanguages)
                    .ThenInclude(xa => xa.Language)
                .Include(x => x.RaceTraits)
                    .ThenInclude(xa => xa.Trait)
                .ToListAsync();
        }

        public async Task<Race> GetById(Guid raceId)
        {
            return await _dbContext.Races
                .Where(x => x.Id == raceId)
                .Include(x => x.RacesLanguages)
                    .ThenInclude(xa => xa.Language)
                .Include(x => x.RaceTraits)
                    .ThenInclude(xa => xa.Trait)
                .FirstOrDefaultAsync();
        }
    }
}