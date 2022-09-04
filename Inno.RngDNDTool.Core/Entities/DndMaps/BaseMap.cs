using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndMaps
{
    public class BaseMap : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName  { get; set; }
        public string FilePath  { get; set; }
        public string FileUrl  { get; set; }
        public string FileType  { get; set; }
        public bool IsPublic  { get; set; }
        public ICollection<ApplicationUserMaps> ApplicationUserMaps { get; set; }
    }
}
