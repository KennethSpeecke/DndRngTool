using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor
{
    public class Armor : BaseItem
    {
        #region Public Properties

        public int ArmorClass { get; set; } = 0;
        public BodyPlacementTypes BodyPlacement { get; set; } = BodyPlacementTypes.Cape;
        public ICollection<InventoryArmors> InventoryArmors { get; set; }

        #endregion Public Properties
    }
}