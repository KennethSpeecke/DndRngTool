using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class CharactersClasses
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }
}
