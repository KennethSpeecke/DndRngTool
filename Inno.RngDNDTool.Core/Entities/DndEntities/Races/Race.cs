using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Races
{
    public class Race : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<CharacterRaces> CharacterRaces { get; set; }
        public string Allignment { get; set; }
        public ICollection<RaceTraits> RaceTraits { get; set; }
        public ICollection<RacesLanguages> RacesLanguages { get; set; }
        public string Description { get; set; }
    }
}
