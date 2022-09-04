using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface IWeaponRepository
    {
        Task<ICollection<Weapon>> GetAsync();
        Task<Weapon> GetByIdAsync(Guid id);
        Task AddAsync(Weapon weapon);
        Task AddCollectionAsync(ICollection<Weapon> weapons);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Weapon weapon);
    }
}
