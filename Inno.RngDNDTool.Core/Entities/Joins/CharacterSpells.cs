using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class CharacterSpells
    {
        public Guid SpellId { get; set; }
        public BaseSpell Spell { get; set; }
        public Character Character { get; set; }
        public Guid CharacterId { get; set; }
    }
}
