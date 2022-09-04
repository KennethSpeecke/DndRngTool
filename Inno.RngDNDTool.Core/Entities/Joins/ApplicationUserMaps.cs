using Inno.RngDNDTool.Core.Entities.DndMaps;
using Inno.RngDNDTool.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class ApplicationUserMaps
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid MapId { get; set; }
        public BaseMap Map { get; set; }
    }
}
