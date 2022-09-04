using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class CharacterRaces
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
        public Guid RaceId { get; set; }
        public Race Race { get; set; }
    }
}
