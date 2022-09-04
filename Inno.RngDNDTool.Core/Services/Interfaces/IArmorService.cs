using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Services.Interfaces
{
    public interface IArmorService
    {
        Task SyncArmorFromExtrernalSource(string sourceUrl);
    }
}
