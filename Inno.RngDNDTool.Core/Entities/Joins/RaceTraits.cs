using Inno.RngDNDTool.Core.Entities.DndEntities;
using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class RaceTraits
    {
        public Guid RaceId { get; set; }
        public Race Race { get; set; }
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; }
    }
}
