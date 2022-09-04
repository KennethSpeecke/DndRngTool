using Inno.RngDNDTool.Core.Entities.DndEntities.Dices;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables
{
    public class Potion : BaseItem
    {
        #region Public Properties

        public PotionTypes PotionType { get; set; } = PotionTypes.Healing;
        public int StatusEffectDurationInMinutes { get; set; } = 5;
        public int StatusEffectValue { get; set; } = 0;
        public ICollection<InventoryPotions> InventoryPotions  { get; set; }

        #endregion Public Properties
    }
}