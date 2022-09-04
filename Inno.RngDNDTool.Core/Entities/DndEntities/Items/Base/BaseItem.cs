using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Currencies.Coins;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Base
{
    public class BaseItem : BaseEntity<Guid>
    {
        #region Public Properties

        public int BuyPrice { get; set; }
        public string Description { get; set; } = ItemDefaults.defaultItemDescription;
        public string ItemImageUrl { get; set; } = ItemDefaults.defaultItemImageUrl;
        public string Name { get; set; } = ItemDefaults.defaultItemName;
        public RarityTypes Rarity { get; set; } = RarityTypes.Common;
        public int SellPrice { get; set; }
        public double WeightInKg { get; set; } = 0;

        #endregion Public Properties
    }
}