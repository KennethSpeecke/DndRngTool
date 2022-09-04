using Inno.RngDNDTool.Core.Constants.Errors.Defaults;
using Inno.RngDNDTool.Core.Entities.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using Inno.RngDNDTool.Core.Entities.DndEntities.Skills;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Inno.RngDNDTool.Core.Entities.Joins;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Characters
{
    public class Character : CoreSkills
    {
        #region Public Constructors

        public Character()
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
            //MaxCarryWeight = CoreSkills.Strength * 5;
        }

        #endregion Public Constructors

        #region Public Properties

        public int Age { get; set; }
        public string Allignment { get; set; }
        public ICollection<ApplicationUserCharacters> ApplicationUserCharacters { get; set; }
        public int ArmorClass { get; set; } = 10;
        public string Background { get; set; }
        public string Bonds { get; set; }
        public ICollection<CharacterRaces> CharacterRaces { get; set; }
        public ICollection<CharactersClasses> CharactersClasses { get; set; }
        public ICollection<CharacterSpells> CharacterSpells { get; set; }
        public int CurrentHitPoints { get; set; }
        public int CurrentWeightCarried { get; set; } = 0;
        public Armor EquipedArmor { get; set; }
        public Guid EquipedArmorId { get; set; }
        public Weapon EquipedMainHandWeapon { get; set; }
        public Guid EquipedMainHandWeaponId { get; set; }
        public int Experience { get; set; }
        public string Flaws { get; set; }
        public string Ideals { get; set; }
        public int Initiative { get; set; } = 0;
        public int InitiativeBonus { get; set; } = 0;
        public Inventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsEncumbered { get; set; }
        public int Level { get; set; }
        public int MaxCarryWeight { get; set; } = 10;
        public int MaxHitPoints { get; set; }
        public string Name { get; set; } = CharacterDefaults.DefaultName;
        public int PassiveWisdom { get; set; } = 10;
        public string PersonalTraits { get; set; }
        public int ProficiencyBonus { get; set; } = 0;
        public string Race { get; set; }
        public int RequiredMultiClassLevel { get; set; } = 5;
        public int Speed { get; set; } = 0;
        public int TemporaryHitpoints { get; set; }

        #endregion Public Properties
    }
}