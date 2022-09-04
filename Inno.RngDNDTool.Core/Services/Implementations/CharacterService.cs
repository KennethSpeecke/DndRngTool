using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Implementations
{
    public class CharacterService : ICharacterService
    {
        private readonly IArmorRepository _armorRepository;
        private readonly ICharacterClassRepository _characterClassRepository;
        private readonly ICharacterRepository _characterRepository;
        private readonly IRaceRepository _raceRepository;
        private readonly IWeaponRepository _weaponRepository;

        public CharacterService(ICharacterRepository characterRepository, IRaceRepository raceRepository, ICharacterClassRepository characterClassRepository, IArmorRepository armorRepository, IWeaponRepository weaponRepository)
        {
            _characterRepository = characterRepository;
            _raceRepository = raceRepository;
            _characterClassRepository = characterClassRepository;
            _armorRepository = armorRepository;
            _weaponRepository = weaponRepository;
        }

        public async Task<bool> AddAsync(Character character)
        {
            try
            {
                var charList = await _characterRepository.GetAsync();

                if (charList.Any(x => x.Id == character.Id))
                {
                    await _characterRepository.UpdateAsync(character);
                }
                else
                {
                    character.Id = Guid.NewGuid();
                    character = await ValidateCharacterModel(character);
                    await _characterRepository.AddAsync(character);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Character>> GetAsync()
        {
            var foundCharacters = await _characterRepository.GetAsync();
            if (foundCharacters != null)
            {
                return foundCharacters;
            }
            else
                return new List<Character>();
        }

        public async Task<Character> GetByIdAsync(Guid id)
        {
            var foundChar = await _characterRepository.GetByIdAsync(id);

            if (foundChar != null)
                return foundChar;
            else
                return new Character();
        }

        public Task UpdateAsync(Character character)
        {
            throw new NotImplementedException();
        }

        private async Task<Character> ValidateCharacterModel(Character character)
        {
            if (character.Inventory.Id.Equals(Guid.Empty))
            {
                character.Inventory = new Inventory(true);
                character.Inventory.CharacterId = character.Id;
                character.Inventory.Id = Guid.NewGuid();
                character.InventoryId = character.Inventory.Id;
                foreach (var item in character.CharacterRaces)
                {
                    item.CharacterId = character.Id;
                    item.Race = await _raceRepository.GetById(item.RaceId);
                };
                foreach (var item in character.CharactersClasses)
                {
                    item.CharacterId = character.Id;
                    item.CharacterClass = await _characterClassRepository.GetById(item.CharacterClassId);
                }
                character.Inventory.InventoryArmors = new List<InventoryArmors>
                {
                    new InventoryArmors
                    {
                        InventoryId = character.Inventory.Id,
                        ArmorId = Guid.Parse("A66F53E9-605D-4EDE-AF78-F6CC985203EF"),
                    }
                };
                foreach (var item in character.Inventory.InventoryArmors)
                {
                    item.Armor = await _armorRepository.GetById(item.ArmorId);
                }
                character.EquipedArmor = await _armorRepository.GetById(character.Inventory.InventoryArmors.FirstOrDefault().ArmorId);
                character.Inventory.InventoryWeapons = new List<InventoryWeapons>
                {
                    new InventoryWeapons
                    {
                        InventoryId = character.InventoryId,
                        WeaponId = Guid.Parse("8ECD50D4-9079-4428-9EC5-F45B5ABCE6C7")
                    }
                };
                foreach (var item in character.Inventory.InventoryWeapons)
                {
                    item.Weapon = await _weaponRepository.GetByIdAsync(item.WeaponId);
                }
                character.EquipedMainHandWeapon = await _weaponRepository.GetByIdAsync(character.Inventory.InventoryWeapons.FirstOrDefault().WeaponId);
                character.EquipedArmorId = Guid.Parse("A66F53E9-605D-4EDE-AF78-F6CC985203EF");
                character.EquipedMainHandWeaponId = Guid.Parse("8ECD50D4-9079-4428-9EC5-F45B5ABCE6C7");
            }

            return character;
        }
    }
}