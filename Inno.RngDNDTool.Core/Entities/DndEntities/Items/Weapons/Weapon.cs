using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Dices;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons
{
    public class Weapon : BaseItem
    {
        #region Public Properties

        public int DamageDice { get; set; } = 0;
        public DamageTypes DamageType { get; set; } = DamageTypes.Bludgeoning;
        public WeaponTypes WeaponType { get; set; } = WeaponTypes.SimpleMeleeWeapons;
        public ICollection<InventoryWeapons> InventoryWeapons { get; set; }
        public int Range { get; set; }

        #endregion Public Properties
    }
}