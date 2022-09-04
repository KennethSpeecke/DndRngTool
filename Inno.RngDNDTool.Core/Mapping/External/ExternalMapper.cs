using Inno.RngDNDTool.Core.DtoModels.External;
using Inno.RngDNDTool.Core.DtoModels.External.Armor;
using Inno.RngDNDTool.Core.DtoModels.External.Potion;
using Inno.RngDNDTool.Core.DtoModels.External.Scroll;
using Inno.RngDNDTool.Core.DtoModels.External.Weapon;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Enums;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Inno.RngDNDTool.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Mapping.External
{
    public class ExternalMapper
    {
        public async Task<BaseSpell> MapSpellObjectFromExternalSource(SpellDTO externalObject)
        {
            var newSpell = new BaseSpell
            {
                Id = Guid.NewGuid(),
                CastingTime = externalObject.casting_time,
                AttackRadiusInMeters = FormatRangeOfAttack(externalObject.range),
                Description = externalObject.desc.FirstOrDefault(),
                Level = externalObject.level,
                Name = externalObject.name,
                Duration = externalObject.duration,
                Material = externalObject.material ?? "None.",
                Concentration = externalObject.concentration,
                Ritual = externalObject.ritual
            };

            if (externalObject.damage == null)
            {
                externalObject.damage = new DamageDTO();

                if (externalObject.damage.damage_at_slot_level == null)
                {
                    externalObject.damage.damage_at_slot_level = new DamageLevelDTO();
                    newSpell.DamageRoll = DiceHelper.GetDiceBySides(int.Parse(FormatDiceName(externalObject.damage.damage_at_slot_level.None))).MaxValue;
                }
                if (externalObject.damage.damage_type == null)
                {
                    externalObject.damage.damage_type = new DamageTypeDTO { name = "none", url = "na" };
                }
            }
            return newSpell;
        }

        public async Task<Armor> MapArmorObjectFromExternalSource(ArmorDTO armorDTO)
        {
            var newArmor = new Armor
            {
                Id = Guid.NewGuid(),
                Name = armorDTO.Name,
                WeightInKg = armorDTO.Weight,
                BodyPlacement = BodyPlacementTypes.Waist
            };

            if (armorDTO.ArmorClass == null)
                newArmor.ArmorClass = 0;
            else
                newArmor.ArmorClass = armorDTO.ArmorClass.Base;

            if (armorDTO.Rarity == null)
                newArmor.Rarity = RarityTypes.Common;
            else
            {
                newArmor.Rarity = CalculateRarityType(armorDTO.Rarity);
            }

            if (armorDTO.Costs == null)
            {
                newArmor.BuyPrice = 0;
                newArmor.SellPrice = 0;
            }
            else
            {
                newArmor.BuyPrice = armorDTO.Costs.Quantity;
                newArmor.SellPrice = armorDTO.Costs.Quantity - 1;
            }

            newArmor.Description = FormatArrayOfDescriptionsToSingleLine(armorDTO.Descriptions);


            return newArmor;
        }

        public async Task<Potion> MapPotionObjectFromExternalSource(PotionDTO potionDTO)
        {
            var newPotion = new Potion
            {
                Id = Guid.NewGuid(),
                BuyPrice = 0,
                SellPrice = 0,
                Name = potionDTO.Name,
                StatusEffectDurationInMinutes = 0,
                PotionType = PotionTypes.Buff,
                WeightInKg = 0,
                StatusEffectValue = 0
            };

            newPotion.Rarity = CalculateRarityType(potionDTO.Rarity);
            newPotion.Description = FormatArrayOfDescriptionsToSingleLine(potionDTO.Descriptions);
            return newPotion;
        }

        public async Task<Weapon> MapWeaponObjectFromExternalSource(WeaponDTO weaponDTO)
        {
            var newWeapon = new Weapon
            {
                Id = Guid.NewGuid(),
                Description = FormatArrayOfDescriptionsToSingleLine(weaponDTO.Descriptions),
                Name = weaponDTO.Name,
                Rarity = CalculateRarityType(weaponDTO.Rarity),
                WeaponType = CalculateWeaponType(weaponDTO.WeaponType),
                BuyPrice = CalculateCost(weaponDTO.Cost),
                SellPrice = CalculateCost(weaponDTO.Cost),
                DamageDice = CalculateMaxDamageDice(weaponDTO.Damage),
                DamageType = CalculateDamageType(weaponDTO.Damage),
                WeightInKg = weaponDTO.Weight,
                Range = CalculateWeaponRange(weaponDTO.Range)
            };

            return newWeapon;
        }

        public async Task<Scroll> MapScrollObjectFromExternalSource(ScrollDTO scrollDTO) 
        {
            var newScroll = new Scroll 
            {
                Id = Guid.NewGuid(),
                Description = FormatArrayOfDescriptionsToSingleLine(scrollDTO.Descriptions),
                Name = scrollDTO.Name,
                Rarity = CalculateRarityType(scrollDTO.Rarity),
                WeightInKg = 0,
                BuyPrice = 0,
                SellPrice = 0,
                RequiredDifficultyClass = 0
            };

            return newScroll;
        }

        private int CalculateWeaponRange(RangeDTO rangeDTO) 
        {
            if (rangeDTO == null)
            {
                return 0;
            }

            return rangeDTO.Range;
        }

        private DamageTypes CalculateDamageType(DamageDTO damageDTO) 
        {
            if (damageDTO == null)
            {
                return DamageTypes.Bludgeoning;
            }

            foreach (DamageTypes type in Enum.GetValues(typeof(DamageTypes)))
            {
                if (type.ToString().ToUpper() == damageDTO.damage_type.name.ToUpper())
                {
                    return type;
                }
            }

            return DamageTypes.Bludgeoning;
        }
        private int CalculateMaxDamageDice(DamageDTO damageDTO)
        {
            if (damageDTO == null)
            {
                return 0;
            }

            var splicedDiceString = damageDTO.DamageDice.Remove(0, 1);

            switch (splicedDiceString)
            {
                case "d4":
                    return 4;
                case "d6":
                    return 6;
                case "d8":
                    return 8;
                case "d10":
                    return 10;
                case "d12":
                    return 12;
                case "d20":
                    return 20;
                default:
                    return 0;
            }
        }
        private int CalculateCost(CostDTO costDTO)
        {
            var finalCost = 0;
            if (costDTO == null)
            {
                return finalCost;
            }
            else
            {
                finalCost = costDTO.Quantity;
            }

            return finalCost;
        }

        private WeaponTypes CalculateWeaponType(string input)
        {
            WeaponTypes result;

            switch (input)
            {
                case "Simple Melee":
                    result = WeaponTypes.SimpleMeleeWeapons;
                    break;
                case "Simple Ranged":
                    result = WeaponTypes.SimpleRangedWeapons;
                    break;
                case "Martial Melee":
                    result = WeaponTypes.MartialMeleeWeapons;
                    break;
                case "Martial Ranged":
                    result = WeaponTypes.MartialRangedWeapons;
                    break;
                case "Magical":
                    result = WeaponTypes.Magical;
                    break;
                default:
                    result = WeaponTypes.SimpleMeleeWeapons;
                    break;
            }

            return result;
        }

        private string FormatArrayOfDescriptionsToSingleLine(string[] input)
        {
            var result = "";
            if (input.Count() > 0)
            {
                foreach (var description in input)
                {
                    result += $" ~{description}~ ";
                }
            }
            else
                result = "No descriptions available.";

            return result;
        }

        private RarityTypes CalculateRarityType(RarityDTO rarityDTO)
        {
            if (rarityDTO == null)
            {
                return RarityTypes.Common;
            }
            RarityTypes result;
            switch (rarityDTO.Name)
            {
                case "Common":
                    result = RarityTypes.Common;
                    break;
                case "Uncommon":
                    result = RarityTypes.Uncommon;
                    break;
                case "Rare":
                    result = RarityTypes.Rare;
                    break;
                case "Very Rare":
                    result = RarityTypes.VeryRare;
                    break;
                case "Legendary":
                    result = RarityTypes.Legendary;
                    break;
                case "Artifact":
                    result = RarityTypes.Artifact;
                    break;
                default:
                    result = RarityTypes.Common;
                    break;
            }

            return result;
        }

        public static int FormatRangeOfAttack(string externalInput)
        {
            int result = 0;
            if (externalInput.ToUpper().Contains("FEET"))
            {
                result = int.Parse(externalInput.Replace("feet", "").Trim());
            }
            if (externalInput.ToUpper().Contains("SELF"))
            {
                result = 0;
            }
            return result;
        }

        public static string FormatDiceName(string input)
        {
            var result = "";
            if (input.Length == 3)
            {
                result = input.Remove(0, 2);
            }
            if (input.Length > 3)
            {
                result = input.Remove(0, 3);
            }
            if (result == "")
            {
                result = input;
            }
            return result;
        }
    }
}
