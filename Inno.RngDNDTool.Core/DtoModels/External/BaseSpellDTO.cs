using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.External
{
    public class BaseSpellDTO
    {
        public ICollection<SpellDTO> results { get; set; }
    }
}
