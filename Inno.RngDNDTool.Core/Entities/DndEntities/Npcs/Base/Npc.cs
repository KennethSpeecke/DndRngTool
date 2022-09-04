using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Npcs.Types;
using Inno.RngDNDTool.Core.Entities.DndEntities.Skills;
using Inno.RngDNDTool.Core.Entities.Joins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Npcs.Base
{
    public class Npc : CoreSkills
    {
        #region Public Constructors

        public Npc()
        {
            //MetaSkills.Acrobatics += CoreSkills.Dexterity;
            //MetaSkills.AnimalHandling += CoreSkills.Wisdom;
            //MetaSkills.Arcana += CoreSkills.Intelligence;
            //MetaSkills.Athletics += CoreSkills.Strength;
            //MetaSkills.Deception += CoreSkills.Charisma;
            //MetaSkills.History += CoreSkills.Intelligence;
            //MetaSkills.Insight += CoreSkills.Wisdom;
            //MetaSkills.Intimidation += CoreSkills.Charisma;
            //MetaSkills.Investigation += CoreSkills.Intelligence;
            //MetaSkills.Medicine += CoreSkills.Wisdom;
            //MetaSkills.Nature += CoreSkills.Intelligence;
            //MetaSkills.Perception += CoreSkills.Wisdom;
            //MetaSkills.Performance += CoreSkills.Charisma;
            //MetaSkills.Persuasion += CoreSkills.Charisma;
            //MetaSkills.Religion += CoreSkills.Intelligence;
            //MetaSkills.SleightOfHand += CoreSkills.Dexterity;
            //MetaSkills.Stealth += CoreSkills.Dexterity;
            //MetaSkills.Survival += CoreSkills.Wisdom;
            //PassiveWisdom += MetaSkills.Perception;
            //ArmorClass += CoreSkills.Dexterity;
        }

        #endregion Public Constructors

        #region Public Properties

        public int ArmorClass { get; set; } = 10;
        public NpcBehaviorTypes BehaviorType { get; set; } = NpcBehaviorTypes.Neutral;
        public string Description { get; set; } = NpcDefaults.defaultNpcDescription;
        public int Initiative { get; set; } = 0;
        public Inventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
        public string Name { get; set; } = NpcDefaults.defaultNpcName;
        public int PassiveWisdom { get; set; } = 10;
        public int ProficiencyBonus { get; set; } = 0;
        public int Speed { get; set; } = 20;
        public ICollection<NpcClasses> NpcClasses { get; set; }
        public ICollection<NpcSpells> NpcSpells { get; set; }

        #endregion Public Properties
    }
}