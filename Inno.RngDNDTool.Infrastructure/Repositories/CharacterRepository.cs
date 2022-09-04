using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
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
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CharacterRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Character character)
        {
            await _dbContext.AddAsync(character);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Character> EquipMainHandWeapon(Guid weaponId)
        {
            throw new NotImplementedException();
        }

        public Task<Character> EquipOffHandWeapon(Guid weaponId)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Character>> GetAsync()
        {
            var foundCharacters = await _dbContext
                .Characters
                .Where(x => x.IsDeleted != true)
                .AsNoTracking()
                .Include(c => c.Inventory)
                    .ThenInclude(i => i.InventoryWeapons)
                        .ThenInclude(iw => iw.Weapon)
                .Include(c => c.Inventory)
                    .ThenInclude(i => i.InventoryFoods.Where(x => x.IsConsumed != true))
                        .ThenInclude(iff => iff.Food)
                .Include(c => c.Inventory)
                    .ThenInclude(i => i.InventoryPotions.Where(x => x.IsConsumed != true))
                        .ThenInclude(ip => ip.Potion)
                .Include(c => c.Inventory)
                    .ThenInclude(i => i.InventoryScrolls.Where(x => x.IsConsumed != true))
                        .ThenInclude(iss => iss.Scroll)
                .Include(c => c.Inventory)
                    .ThenInclude(i => i.InventoryArmors)
                        .ThenInclude(ia => ia.Armor)
                .Include(c => c.CharacterSpells)
                    .ThenInclude(cp => cp.Spell)
                .Include(c => c.CharacterRaces)
                    .ThenInclude(cr => cr.Race)
                        .ThenInclude(r => r.RaceTraits)
                            .ThenInclude(rt => rt.Trait)
                .Include(c => c.CharacterRaces)
                    .ThenInclude(cr => cr.Race)
                        .ThenInclude(r => r.RacesLanguages)
                            .ThenInclude(rt => rt.Language)
                .Include(c => c.CharactersClasses)
                    .ThenInclude(cc => cc.CharacterClass)
                        .ThenInclude(cc => cc.CharacterClassesAbilities)
                            .ThenInclude(cca => cca.Ability)
                .Include(c => c.CharactersClasses)
                    .ThenInclude(cc => cc.CharacterClass)
                        .ThenInclude(cc => cc.CharacterClassLanguages)
                            .ThenInclude(cca => cca.Language)
                .Include(c => c.CharactersClasses)
                    .ThenInclude(cc => cc.CharacterClass)
                        .ThenInclude(cc => cc.CharacterClassesTraits)
                            .ThenInclude(cca => cca.Trait)
                        .ToListAsync();

            return foundCharacters;
        }

        public async Task<Character> GetByIdAsync(Guid id)
        {
            var foundChar = await _dbContext
                .Characters
                .Where(c => c.Id == id && c.IsDeleted != true)
                    .Include(c => c.Inventory)
                        .ThenInclude(i => i.InventoryWeapons)
                            .ThenInclude(iw => iw.Weapon)
                    .Include(c => c.Inventory)
                        .ThenInclude(i => i.InventoryFoods.Where(x => x.IsConsumed != true))
                            .ThenInclude(iff => iff.Food)
                    .Include(c => c.Inventory)
                        .ThenInclude(i => i.InventoryPotions.Where(x => x.IsConsumed != true))
                            .ThenInclude(ip => ip.Potion)
                    .Include(c => c.Inventory)
                        .ThenInclude(i => i.InventoryScrolls.Where(x => x.IsConsumed != true))
                            .ThenInclude(iss => iss.Scroll)
                    .Include(c => c.Inventory)
                        .ThenInclude(i => i.InventoryArmors)
                            .ThenInclude(ia => ia.Armor)
                    .Include(c => c.CharacterSpells)
                        .ThenInclude(cp => cp.Spell)
                    .Include(c => c.CharacterRaces)
                    .ThenInclude(cr => cr.Race)
                        .ThenInclude(r => r.RaceTraits)
                            .ThenInclude(rt => rt.Trait)
                    .Include(c => c.CharacterRaces)
                        .ThenInclude(cr => cr.Race)
                            .ThenInclude(r => r.RacesLanguages)
                                .ThenInclude(rt => rt.Language)
                    .Include(c => c.CharactersClasses)
                        .ThenInclude(cc => cc.CharacterClass)
                            .ThenInclude(cc => cc.CharacterClassesAbilities)
                                .ThenInclude(cca => cca.Ability)
                    .Include(c => c.CharactersClasses)
                        .ThenInclude(cc => cc.CharacterClass)
                            .ThenInclude(cc => cc.CharacterClassLanguages)
                                .ThenInclude(cca => cca.Language)
                    .Include(c => c.CharactersClasses)
                        .ThenInclude(cc => cc.CharacterClass)
                            .ThenInclude(cc => cc.CharacterClassesTraits)
                                .ThenInclude(cca => cca.Trait)
                        .FirstAsync();

            return foundChar;
        }

        public async Task UpdateAsync(Character character)
        {
            _dbContext.Update(character);
            await _dbContext.SaveChangesAsync();
        }
    }
}