using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Base
{
    public class BaseError
    {
        #region Public Properties

        public string? Message { get; set; }
        public string? ObjectName { get; set; }
        public string? PropertyName { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Title { get; set; }

        #endregion Public Properties
    }
}