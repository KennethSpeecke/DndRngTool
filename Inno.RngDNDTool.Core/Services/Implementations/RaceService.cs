using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Implementations
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository _raceRepository;

        public RaceService(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
        }

        public async Task<ICollection<Race>> Get()
        {
            return await _raceRepository.Get();
        }

        public async Task<Race> GetById(Guid raceId)
        {
            return await _raceRepository.GetById(raceId);
        }
    }
}