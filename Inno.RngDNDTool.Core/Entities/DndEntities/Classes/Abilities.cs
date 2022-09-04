using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Classes
{
    public class Abilities
    {
        #region Public Properties

        public string Description { get; set; } = AbilityDefaults.defaultAbilityDescription;
        public Guid Id { get; set; }
        public string Name { get; set; } = AbilityDefaults.defaultAbilityName;
        public int RequiredLevel { get; set; } = 0;
        public ICollection<CharacterClassesAbilities> CharacterClassesAbilities { get; set; }

        #endregion Public Properties
    }
}