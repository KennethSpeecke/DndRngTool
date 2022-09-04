using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Base
{
    public class BaseResult<TKey> : BaseEntity<TKey>
    {
        #region Public Properties

        public ICollection<BaseError> Errors { get; set; }
        public bool HasErrors { get; set; }

        #endregion Public Properties
    }
}