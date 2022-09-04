using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Interfaces
{
    public interface ICharacterClassService
    {
        Task<ICollection<CharacterClass>> Get();

        Task<CharacterClass> GetById(Guid characterClassId);
    }
}