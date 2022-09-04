using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Classes
{
    public class CoreClass : Proficiencies
    {
        #region Public Properties

        public int HitDice { get; set; } = 0;
        public int HitPoints { get; set; } = 0;

        #endregion Public Properties
    }
}