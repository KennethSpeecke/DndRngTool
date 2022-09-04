using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External
{
    public class SpellDTO
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string range { get; set; }
        public bool ritual { get; set; }
        public string duration { get; set; }
        public string casting_time { get; set; }
        public int level { get; set; }
        public DamageDTO damage { get; set; }
        public ICollection<string> desc { get; set; }
        public bool concentration { get; set; } = false;
        public string? material { get; set; }
    }
}
