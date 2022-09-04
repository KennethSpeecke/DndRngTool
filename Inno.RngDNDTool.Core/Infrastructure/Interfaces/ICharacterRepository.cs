using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Infrastructure.Interfaces
{
    public interface ICharacterRepository
    {
        Task AddAsync(Character character);

        Task DeleteAsync(Guid id);

        Task<Character> EquipMainHandWeapon(Guid weaponId);

        Task<Character> EquipOffHandWeapon(Guid weaponId);

        Task<ICollection<Character>> GetAsync();

        Task<Character> GetByIdAsync(Guid id);

        Task UpdateAsync(Character character);
    }
}