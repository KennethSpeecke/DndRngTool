using Inno.RngDNDTool.Core.Entities.DndEntities;
using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class CharacterClassesTraits
    {
        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; }
    }
}
