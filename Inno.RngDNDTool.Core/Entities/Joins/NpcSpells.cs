using Inno.RngDNDTool.Core.Entities.DndEntities.Npcs.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class NpcSpells
    {
        public Guid SpellId { get; set; }
        public BaseSpell Spell { get; set; }
        public Guid NpcId { get; set; }
        public Npc Npc { get; set; }
    }
}
