using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities
{
    public class Language : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CharacterClassLanguages> CharacterClassLanguages { get; set; }
        public ICollection<RacesLanguages> RacesLanguages { get; set; }

    }
}
