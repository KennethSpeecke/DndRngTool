using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Classes
{
    public class Proficiencies : BaseEntity<Guid>
    {
        #region Public Properties

        public ArmorTypes ArmorProficiencies { get; set; }
        public WeaponTypes WeaponProficiencies { get; set; }

        #endregion Public Properties
    }
}