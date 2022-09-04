using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<ICollection<Character>> GetAsync();
        Task<Character> GetByIdAsync(Guid id);
        Task<bool> AddAsync(Character character);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Character character);
    }
}
