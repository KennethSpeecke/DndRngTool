using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Skills
{
    public class CoreSkills : MetaSkills
    {
        #region Public Properties

        public int Charisma { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Strength { get; set; } = 0;
        public int Wisdom { get; set; } = 0;

        #endregion Public Properties
    }
}