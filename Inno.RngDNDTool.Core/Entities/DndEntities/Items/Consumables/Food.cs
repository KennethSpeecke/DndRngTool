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
    public class Food : BaseItem
    {
        #region Public Properties

        public FoodTypes FoodTypes { get; set; }
        public int StatusEffectDurationInMinutes { get; set; } = 5;
        public PotionTypes StatusEffectType { get; set; } = PotionTypes.Buff;
        public int StatusEffectValue { get; set; } = 0;
        public ICollection<InventoryFoods> InventoryFoods { get; set; }

        #endregion Public Properties
    }
}