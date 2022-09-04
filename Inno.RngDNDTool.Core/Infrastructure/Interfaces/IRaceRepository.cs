using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IRaceRepository
    {
        Task<ICollection<Race>> Get();

        Task<Race> GetById(Guid raceId);
    }
}