using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Classes
{
    public class CharacterClass : CoreClass
    {
        #region Public Properties

        public ICollection<CharacterClassesAbilities> CharacterClassesAbilities { get; set; }
        public string Description { get; set; } = CharacterClassDefaults.defaultCharacterClassDescription;
        public string Name { get; set; } = CharacterClassDefaults.defaultCharacterClassName;
        public ICollection<CharacterClassesTraits> CharacterClassesTraits { get; set; }
        public ICollection<CharacterClassLanguages> CharacterClassLanguages { get; set; }
        public ICollection<CharactersClasses> CharactersClasses { get; set; }
        public ICollection<NpcClasses> NpcClasses { get; set; }

        #endregion Public Properties
    }
}