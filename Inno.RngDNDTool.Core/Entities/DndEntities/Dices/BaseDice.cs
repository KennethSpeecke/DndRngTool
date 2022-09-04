using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Dices
{
    public class BaseDice
    {
        #region Public Constructors

        public BaseDice(int minValue, int maxValue)
        {
            MaxValue = maxValue;
            MinValue = minValue;
        }

        #endregion Public Constructors

        #region Public Properties
        public Guid Id { get; set; }
        public int MaxValue { get; set; } = 0;
        public int MinValue { get; set; } = 0;

        #endregion Public Properties
    }
}