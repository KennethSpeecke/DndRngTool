using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor
{
    public class StealthClass : Armor
    {
        #region Public Properties

        public bool HasAdvantage { get; set; }
        public int StealthBonus { get; set; } = 0;

        #endregion Public Properties
    }
}