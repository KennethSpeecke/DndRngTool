using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Currencies.Coins
{
    public class Coin : BaseItem
    {
        #region Public Properties

        public CoinTypes CoinMetalType { get; set; }

        #endregion Public Properties
    }
}