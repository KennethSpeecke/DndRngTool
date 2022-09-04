using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Entities.DndEntities.Npcs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class NpcClasses
    {
        public Guid NpcId { get; set; }
        public Npc Npc { get; set; }
        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }
}
