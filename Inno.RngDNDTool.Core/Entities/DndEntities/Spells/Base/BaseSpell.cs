using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Dices;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base
{
    public class BaseSpell : BaseEntity<Guid>
    {
        #region Public Properties

        public int AttackRadiusInMeters { get; set; } = 0;
        public string CastingTime { get; set; } = SpellDefaults.defaultSpellCastingTime;
        public int DamageRoll { get; set; } = 0;
        public DamageTypes DamageType { get; set; } = DamageTypes.Necrotic;
        public string Description { get; set; } = SpellDefaults.defaultSpellDescription;
        public string ImageUrl { get; set; } = SpellDefaults.defaultSpellImageUrl;
        public int Level { get; set; } = 1;
        public string Name { get; set; } = SpellDefaults.defaultSpellName;
        public SavingThrowTypes RequiredSavingThrowType { get; set; } = SavingThrowTypes.Dexterity;
        public bool Concentration { get; set; } = false;
        public bool Ritual { get; set; }
        public string Duration { get; set; }
        public string Material { get; set; }
        public ICollection<CharacterSpells> CharacterSpells { get; set; }
        public ICollection<NpcSpells> NpcSpells { get; set; }

        #endregion Public Properties
    }
}