using Inno.RngDNDTool.Core.Entities.DndEntities.Races;

namespace Inno.RngDNDTool.Core.Services.Interfaces
{
    public interface IRaceService
    {
        Task<ICollection<Race>> Get();

        Task<Race> GetById(Guid raceId);
    }
}