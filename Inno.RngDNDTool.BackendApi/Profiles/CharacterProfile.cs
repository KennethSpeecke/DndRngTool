using AutoMapper;
using Inno.RngDNDTool.Core.DtoModels.Internal;
using Inno.RngDNDTool.Core.DtoModels.Internal.Character;
using Inno.RngDNDTool.Core.DtoModels.Internal.CharacterClass;
using Inno.RngDNDTool.Core.DtoModels.Internal.Identity;
using Inno.RngDNDTool.Core.DtoModels.Internal.Inventory;
using Inno.RngDNDTool.Core.DtoModels.Internal.Items;
using Inno.RngDNDTool.Core.DtoModels.Internal.Races;
using Inno.RngDNDTool.Core.DtoModels.Internal.Spells;
using Inno.RngDNDTool.Core.Entities.DndEntities;
using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Inno.RngDNDTool.Core.Entities.Identity;
using Inno.RngDNDTool.Core.Entities.Joins;
using System.IO.Compression;

namespace Inno.RngDNDTool.BackendApi.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<BaseSpell, SpellDTO>();
            CreateMap<SpellDTO, BaseSpell>();

            CreateMap<RegisterDTO, ApplicationUser>()
                .ForMember(dest => dest.UserName, opt =>
                opt.MapFrom(src => src.Name));

            CreateMap<Race, RaceDTO>()
                .ForMember(dest => dest.Languages, opt =>
                opt.MapFrom(src => src.RacesLanguages.Select(x => x.Language)))
                .ForMember(dest => dest.Traits, opt =>
                opt.MapFrom(src => src.RaceTraits.Select(x => x.Trait)));

            CreateMap<RaceDTO, Race>();

            CreateMap<Abilities, AbilityDTO>();
            CreateMap<AbilityDTO, Abilities>();

            CreateMap<Trait, TraitDTO>();
            CreateMap<TraitDTO, Trait>();

            CreateMap<Language, LanguageDTO>();
            CreateMap<LanguageDTO, Language>();

            CreateMap<Character, CharacterDTO>()
                .ForMember(dest => dest.CharacterClasses, opt =>
                opt.MapFrom(src => src.CharactersClasses.Select(x => x.CharacterClass)))
                .ForMember(dest => dest.CharacterRace, opt =>
                opt.MapFrom(src => src.CharacterRaces.FirstOrDefault().Race))
                .ForMember(dest => dest.Spells, opt =>
                opt.MapFrom(src => src.CharacterSpells.Select(x => x.Spell)));

            CreateMap<CharacterDTO, Character>()
                .ForMember(dest => dest.CharacterSpells, opt =>
                opt.MapFrom(src => src.Spells.Select(x => new CharacterSpells { SpellId = x.Id, CharacterId = src.Id })))
                .ForMember(dest => dest.CharacterRaces, opt =>
                opt.MapFrom(src => new List<CharacterRaces>{ new CharacterRaces { CharacterId = src.Id, RaceId = src.CharacterRace.Id }}))
                .ForMember(dest => dest.CharactersClasses, opt =>
                opt.MapFrom(src => src.CharacterClasses.Select(x => new CharactersClasses { CharacterClassId = x.Id, CharacterId = src.Id })));

            CreateMap<Inventory, InventoryDTO>()
                .ForMember(dest => dest.Potions, opt =>
                opt.MapFrom(src => src.InventoryPotions.Select(x => x.Potion)))
                .ForMember(dest => dest.Foods,
                opt => opt.MapFrom(src => src.InventoryFoods.Select(x => x.Food)))
                .ForMember(dest => dest.Weapons,
                opt => opt.MapFrom(src => src.InventoryWeapons.Select(x => x.Weapon)))
                .ForMember(dest => dest.Armors,
                opt => opt.MapFrom(src => src.InventoryArmors.Select(x => x.Armor)))
                .ForMember(dest => dest.Scrolls,
                opt => opt.MapFrom(src => src.InventoryScrolls.Select(x => x.Scroll)));

            CreateMap<InventoryDTO, Inventory>()
                .ForMember(dest => dest.InventoryArmors, opt =>
                opt.MapFrom(src => src.Armors.Select(x => new InventoryArmors { ArmorId = x.Id, InventoryId = src.Id, IsEquiped = x.IsEquiped })))
                .ForMember(dest => dest.InventoryPotions, opt =>
                opt.MapFrom(src => src.Potions.Select(x => new InventoryPotions { PotionId = x.Id, InventoryId = src.Id, IsConsumed = x.IsConsumed })))
                .ForMember(dest => dest.InventoryFoods, opt =>
                opt.MapFrom(src => src.Foods.Select(x => new InventoryFoods { FoodId = x.Id, InventoryId = src.Id, IsConsumed = x.IsConsumed })))
                .ForMember(dest => dest.InventoryScrolls, opt =>
                opt.MapFrom(src => src.Scrolls.Select(x => new InventoryScrolls { ScrollId = x.Id, InventoryId = src.Id, IsConsumed = x.IsConsumed })))
                .ForMember(dest => dest.InventoryWeapons, opt =>
                opt.MapFrom(src => src.Weapons.Select(x => new InventoryWeapons { WeaponId = x.Id, InventoryId = src.Id, IsEquiped = x.IsEquiped })));

            CreateMap<Potion, PotionDTO>();
            CreateMap<PotionDTO, Potion>();

            CreateMap<Weapon, WeaponDTO>();
            CreateMap<WeaponDTO, Weapon>();

            CreateMap<Food, FoodDTO>();
            CreateMap<FoodDTO, Food>();

            CreateMap<Scroll, ScrollDTO>();
            CreateMap<ScrollDTO, Scroll>();

            CreateMap<ArmorDTO, Armor>();
            CreateMap<Armor, ArmorDTO>();

            CreateMap<CharacterClass, CharacterClassDTO>()
                .ForMember(dest => dest.Abilities, opt =>
                opt.MapFrom(src => src.CharacterClassesAbilities.Select(x => x.Ability)))
                .ForMember(dest => dest.ClassTraits, opt =>
                opt.MapFrom(src => src.CharacterClassesTraits.Select(x => x.Trait)))
                .ForMember(dest => dest.ClassLanguages, opt =>
                opt.MapFrom(src => src.CharacterClassLanguages.Select(x => x.Language)));

            CreateMap<CharacterClassDTO, CharacterClass>();
        }
    }
}