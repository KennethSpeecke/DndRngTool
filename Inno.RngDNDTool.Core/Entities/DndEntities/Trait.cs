using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities
{
    public class Trait : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CharacterClassesTraits> CharacterClassesTraits { get; set; }
        public ICollection<RaceTraits> RaceTraits { get; set; }
    }
}
