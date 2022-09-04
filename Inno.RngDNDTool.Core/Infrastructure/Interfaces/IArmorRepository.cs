using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IArmorRepository
    {
        Task Add(Armor armor);

        Task AddCollection(ICollection<Armor> armor);

        Task Delete(Guid id);

        Task<ICollection<Armor>> Get();

        Task<Armor> GetById(Guid id);

        Task Update(Armor armor);
    }
}