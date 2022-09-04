using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface ISpellRepository
    {
        Task Get();
        Task GetById(Guid Id);
        Task Add(BaseSpell baseSpell);
        Task AddCollection(List<BaseSpell> baseSpells);
        Task Delete(Guid Id);
        Task Update(BaseSpell baseSpell);
    }
}
