using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Skills;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            var characterList = new List<Character> {
                new Character
                {
                    Id = Guid.Parse("29bcd574-1436-4a71-a750-4484d10cb105"),
                    Name = "Copuul",
                    RequiredMultiClassLevel = 5,
                    ArmorClass = 15,
                    Charisma = 8,
                    Constitution = 14,
                    Dexterity = 17,
                    Intelligence = 12,
                    Strength = 10,
                    Wisdom = 14,
                    Initiative = 0,
                    CurrentWeightCarried = 0,
                    InitiativeBonus = 0,
                    IsEncumbered = false,
                    Speed = 25,
                    ProficiencyBonus = 2,
                    PassiveWisdom = 14,
                    MaxCarryWeight = 100,
                    Acrobatics = 5,
                    AnimalHandling = 2,
                    Arcana = 1,
                    Athletics = 0,
                    Deception = -1,
                    History = 1,
                    Insight = 4,
                    Intimidation = -1,
                    Investigation = 1,
                    Medicine = 2,
                    Nature = 1,
                    Perception = 4,
                    Performance = -1,
                    Persuasion = -1,
                    Religion = 3,
                    SleightOfHand = 3,
                    Stealth = 5,
                    Survival = 2,
                    InventoryId = Guid.Parse("82b556d3-ecef-40d6-aaae-12bcf93592d2"),
                    Allignment = "Lawfull Evil",
                    Background = "Acolyte",
                    Experience = 0,
                    Level = 1,
                    Race = "Grung",
                    PersonalTraits = "I see omens in every event and action. The gods try to speak to us, we just need to listen.",
                    Bonds = "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic.",
                    Flaws = "I am suspicious of strangers and expect the worst in them.",
                    Ideals = "Tradition. The ancient traditions of worship and sacrifice must be preserved and upheld.(Lawfull)",
                    MaxHitPoints = 10,
                    CurrentHitPoints = 10,
                    TemporaryHitpoints = 0,
                    EquipedMainHandWeaponId = Guid.Parse("8ECD50D4-9079-4428-9EC5-F45B5ABCE6C7"),
                    EquipedArmorId = Guid.Parse("A66F53E9-605D-4EDE-AF78-F6CC985203EF")

                } 
            };

            modelBuilder.Entity<Character>().HasData(characterList);
        }
    }
}
