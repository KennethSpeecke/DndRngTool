using Inno.RngDNDTool.Core.DtoModels.Internal.Base;
using Inno.RngDNDTool.Core.DtoModels.Internal.CharacterClass;
using Inno.RngDNDTool.Core.DtoModels.Internal.Inventory;
using Inno.RngDNDTool.Core.DtoModels.Internal.Items;
using Inno.RngDNDTool.Core.DtoModels.Internal.Races;
using Inno.RngDNDTool.Core.DtoModels.Internal.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Character
{
    public class CharacterDTO : BaseDTO
    {
        [JsonPropertyName("allignment")]
        public string Allignment { get; set; }

        [JsonPropertyName("armorClass")]
        public int ArmorClass { get; set; }

        [JsonPropertyName("background")]
        public string Background { get; set; }

        [JsonPropertyName("bonds")]
        public string Bonds { get; set; }

        [JsonPropertyName("characterClasses")]
        public ICollection<CharacterClassDTO> CharacterClasses { get; set; }

        [JsonPropertyName("characterRace")]
        public RaceDTO CharacterRace { get; set; }

        [JsonPropertyName("currentWeightCarried")]
        public int CurrentWeightCarried { get; set; }

        [JsonPropertyName("equipedArmor")]
        public ArmorDTO EquipedArmor { get; set; }

        [JsonPropertyName("equipedMainHandWeapon")]
        public WeaponDTO EquipedMainHandWeapon { get; set; }

        [JsonPropertyName("experience")]
        public int Experience { get; set; }

        [JsonPropertyName("flaws")]
        public string Flaws { get; set; }

        [JsonPropertyName("ideals")]
        public string Ideals { get; set; }

        [JsonPropertyName("initiative")]
        public int Initiative { get; set; }

        [JsonPropertyName("initiativeBonus")]
        public int InitiativeBonus { get; set; }

        [JsonPropertyName("inventory")]
        public InventoryDTO Inventory { get; set; }

        [JsonPropertyName("isEncumbered")]
        public bool IsEncumbered { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("maxCarryWeight")]
        public int MaxCarryWeight { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("personalTraits")]
        public string PersonalTraits { get; set; }

        [JsonPropertyName("race")]
        public string Race { get; set; }

        [JsonPropertyName("requiredMultiClassLevel")]
        public int RequiredMultiClassLevel { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("spells")]
        public ICollection<SpellDTO> Spells { get; set; }

        #region Skill Properties

        [JsonPropertyName("acrobatics")]
        public int Acrobatics { get; set; }

        [JsonPropertyName("animalHandling")]
        public int AnimalHandling { get; set; }

        [JsonPropertyName("arcana")]
        public int Arcana { get; set; }

        [JsonPropertyName("athletics")]
        public int Athletics { get; set; }

        [JsonPropertyName("charisma")]
        public int Charisma { get; set; }

        [JsonPropertyName("constitution")]
        public int Constitution { get; set; }

        [JsonPropertyName("currentHitPoints")]
        public int CurrentHitPoints { get; set; }

        [JsonPropertyName("deception")]
        public int Deception { get; set; }

        [JsonPropertyName("dexterity")]
        public int Dexterity { get; set; }

        [JsonPropertyName("history")]
        public int History { get; set; }

        [JsonPropertyName("insight")]
        public int Insight { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("intimidation")]
        public int Intimidation { get; set; }

        [JsonPropertyName("invenstigation")]
        public int Investigation { get; set; }

        [JsonPropertyName("maxHitPoints")]
        public int MaxHitPoints { get; set; }

        [JsonPropertyName("medicine")]
        public int Medicine { get; set; }

        [JsonPropertyName("nature")]
        public int Nature { get; set; }

        [JsonPropertyName("passiveWisdom")]
        public int PassiveWisdom { get; set; }

        [JsonPropertyName("perception")]
        public int Perception { get; set; }

        [JsonPropertyName("performance")]
        public int Performance { get; set; }

        [JsonPropertyName("persuasion")]
        public int Persuasion { get; set; }

        [JsonPropertyName("proficiencyBonus")]
        public int ProficiencyBonus { get; set; }

        [JsonPropertyName("religion")]
        public int Religion { get; set; }

        [JsonPropertyName("sleightOfHand")]
        public int SleightOfHand { get; set; }

        [JsonPropertyName("stealth")]
        public int Stealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("survival")]
        public int Survival { get; set; }

        [JsonPropertyName("temporaryHitpoints")]
        public int TemporaryHitpoints { get; set; }

        [JsonPropertyName("wisdom")]
        public int Wisdom { get; set; }

        #endregion Skill Properties
    }
}