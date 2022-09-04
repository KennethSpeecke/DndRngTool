using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Implementations
{
    public class CharacterClassService : ICharacterClassService
    {
        private readonly ICharacterClassRepository _characterClassRepository;

        public CharacterClassService(ICharacterClassRepository characterClassRepository)
        {
            _characterClassRepository = characterClassRepository;
        }

        public async Task<ICollection<CharacterClass>> Get()
        {
            return await _characterClassRepository.Get();
        }

        public async Task<CharacterClass> GetById(Guid characterClassId)
        {
            return await _characterClassRepository.GetById(characterClassId);
        }
    }
}