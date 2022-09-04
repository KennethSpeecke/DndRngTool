using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables
{
    public class Scroll : BaseItem
    {
        #region Public Properties

        public int RequiredDifficultyClass { get; set; } = 13;
        public Guid? SpellId { get; set; }
        public BaseSpell? Spell { get; set; }
        public ICollection<InventoryScrolls> InventoryScrolls { get; set; }

        #endregion Public Properties
    }
}