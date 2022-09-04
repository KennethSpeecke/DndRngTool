using Inno.RngDNDTool.Core.Entities.DndEntities.Characters;
using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using Inno.RngDNDTool.Core.Entities.DndEntities.Inventories.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Armor;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Consumables;
using Inno.RngDNDTool.Core.Entities.DndEntities.Items.Weapons;
using Inno.RngDNDTool.Core.Entities.DndEntities.Npcs.Base;
using Inno.RngDNDTool.Core.Entities.DndEntities.Races;
using Inno.RngDNDTool.Core.Entities.DndEntities.Skills;
using Inno.RngDNDTool.Core.Entities.DndEntities.Spells.Base;
using Inno.RngDNDTool.Core.Entities.Identity;
using Inno.RngDNDTool.Core.Entities.Joins;
using Inno.RngDNDTool.Infrastructure.Data.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Public Constructors

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<ApplicationUserCharacters> ApplicationUserCharacters { get; set; }
        public DbSet<ApplicationUserMaps> ApplicationUserMaps { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharactersClasses> CharactersClasses { get; set; }
        public DbSet<CharacterSpells> CharacterSpells { get; set; }
        public DbSet<CoreClass> CoreClasses { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryPotions> InventoryPotions { get; set; }
        public DbSet<NpcClasses> NpcClasses { get; set; }
        public DbSet<Npc> Npcs { get; set; }
        public DbSet<NpcSpells> NpcSpells { get; set; }
        public DbSet<Potion> Potions { get; set; }
        public DbSet<Proficiencies> Proficiencies { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Scroll> Scrolls { get; set; }
        public DbSet<BaseSpell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Character>()
                .HasOne(c => c.Inventory)
                .WithOne(i => i.Character)
                .HasForeignKey<Inventory>(c => c.CharacterId);

            builder.Entity<Npc>()
                .HasOne(n => n.Inventory)
                .WithOne(i => i.Npc)
                .HasForeignKey<Inventory>(n => n.NpcId);

            builder.Entity<CharactersClasses>().HasKey(cc => new { cc.CharacterClassId, cc.CharacterId });

            builder.Entity<CharactersClasses>()
                .HasOne(cc => cc.Character)
                .WithMany(c => c.CharactersClasses)
                .HasForeignKey(cc => cc.CharacterId);

            builder.Entity<CharactersClasses>()
                .HasOne(cc => cc.CharacterClass)
                .WithMany(c => c.CharactersClasses)
                .HasForeignKey(cc => cc.CharacterClassId);

            builder.Entity<NpcClasses>().HasKey(nc => new { nc.NpcId, nc.CharacterClassId });

            builder.Entity<NpcClasses>()
                .HasOne(nc => nc.Npc)
                .WithMany(n => n.NpcClasses)
                .HasForeignKey(nc => nc.NpcId);

            builder.Entity<NpcClasses>()
                .HasOne(nc => nc.CharacterClass)
                .WithMany(c => c.NpcClasses)
                .HasForeignKey(nc => nc.CharacterClassId);

            builder.Entity<ApplicationUserCharacters>().HasKey(cc => new { cc.ApplicationUserId, cc.CharacterId });

            builder.Entity<ApplicationUserCharacters>()
                .HasOne(cc => cc.Character)
                .WithMany(c => c.ApplicationUserCharacters)
                .HasForeignKey(cc => cc.CharacterId);

            builder.Entity<ApplicationUserCharacters>()
                .HasOne(cc => cc.ApplicationUser)
                .WithMany(c => c.ApplicationUserCharacters)
                .HasForeignKey(cc => cc.ApplicationUserId);

            builder.Entity<ApplicationUserMaps>().HasKey(cc => new { cc.ApplicationUserId, cc.MapId });

            builder.Entity<ApplicationUserMaps>()
                .HasOne(cc => cc.ApplicationUser)
                .WithMany(c => c.ApplicationUserMaps)
                .HasForeignKey(cc => cc.ApplicationUserId);

            builder.Entity<ApplicationUserMaps>()
                .HasOne(cc => cc.Map)
                .WithMany(c => c.ApplicationUserMaps)
                .HasForeignKey(cc => cc.MapId);

            builder.Entity<CharacterSpells>().HasKey(cs => new { cs.SpellId, cs.CharacterId });

            builder.Entity<CharacterSpells>()
                .HasOne(cs => cs.Character)
                .WithMany(c => c.CharacterSpells)
                .HasForeignKey(cs => cs.CharacterId);

            builder.Entity<CharacterSpells>()
                .HasOne(c => c.Spell)
                .WithMany(cs => cs.CharacterSpells)
                .HasForeignKey(c => c.SpellId);

            builder.Entity<NpcSpells>().HasKey(ns => new { ns.SpellId, ns.NpcId });

            builder.Entity<NpcSpells>()
                .HasOne(ns => ns.Spell)
                .WithMany(n => n.NpcSpells)
                .HasForeignKey(ns => ns.SpellId);

            builder.Entity<NpcSpells>()
                .HasOne(n => n.Npc)
                .WithMany(ns => ns.NpcSpells)
                .HasForeignKey(n => n.NpcId);

            builder.Entity<InventoryPotions>().HasKey(ip => new { ip.PotionId, ip.InventoryId });

            builder.Entity<InventoryPotions>()
                .HasOne(ip => ip.Potion)
                .WithMany(p => p.InventoryPotions)
                .HasForeignKey(ip => ip.PotionId);

            builder.Entity<InventoryPotions>()
                .HasOne(ip => ip.Inventory)
                .WithMany(i => i.InventoryPotions)
                .HasForeignKey(ip => ip.InventoryId);

            builder.Entity<InventoryArmors>().HasKey(ia => new { ia.InventoryId, ia.ArmorId });

            builder.Entity<InventoryArmors>()
                .HasOne(ia => ia.Armor)
                .WithMany(a => a.InventoryArmors)
                .HasForeignKey(ia => ia.ArmorId);

            builder.Entity<InventoryArmors>()
                .HasOne(ia => ia.Inventory)
                .WithMany(i => i.InventoryArmors)
                .HasForeignKey(ia => ia.InventoryId);

            builder.Entity<InventoryFoods>().HasKey(invf => new { invf.InventoryId, invf.FoodId });

            builder.Entity<InventoryFoods>()
                .HasOne(invf => invf.Food)
                .WithMany(f => f.InventoryFoods)
                .HasForeignKey(invf => invf.FoodId);

            builder.Entity<InventoryFoods>()
                .HasOne(invf => invf.Inventory)
                .WithMany(i => i.InventoryFoods)
                .HasForeignKey(invf => invf.InventoryId);

            builder.Entity<InventoryScrolls>().HasKey(iss => new { iss.ScrollId, iss.InventoryId });

            builder.Entity<InventoryScrolls>()
                .HasOne(iss => iss.Scroll)
                .WithMany(s => s.InventoryScrolls)
                .HasForeignKey(iss => iss.ScrollId);

            builder.Entity<InventoryScrolls>()
                .HasOne(iss => iss.Inventory)
                .WithMany(s => s.InventoryScrolls)
                .HasForeignKey(iss => iss.InventoryId);

            builder.Entity<InventoryWeapons>().HasKey(iw => new { iw.WeaponId, iw.InventoryId });

            builder.Entity<InventoryWeapons>()
                .HasOne(iw => iw.Weapon)
                .WithMany(w => w.InventoryWeapons)
                .HasForeignKey(iw => iw.WeaponId);

            builder.Entity<InventoryWeapons>()
                .HasOne(iw => iw.Inventory)
                .WithMany(w => w.InventoryWeapons)
                .HasForeignKey(iw => iw.InventoryId);

            builder.Entity<CharacterRaces>().HasKey(cr => new { cr.RaceId, cr.CharacterId });

            builder.Entity<CharacterRaces>()
                .HasOne(cr => cr.Character)
                .WithMany(c => c.CharacterRaces)
                .HasForeignKey(cr => cr.CharacterId);

            builder.Entity<CharacterRaces>()
                .HasOne(cr => cr.Race)
                .WithMany(c => c.CharacterRaces)
                .HasForeignKey(cr => cr.RaceId);

            builder.Entity<CharacterClassesTraits>().HasKey(cct => new { cct.TraitId, cct.CharacterClassId });

            builder.Entity<CharacterClassesTraits>()
                .HasOne(cct => cct.Trait)
                .WithMany(t => t.CharacterClassesTraits)
                .HasForeignKey(cct => cct.TraitId);

            builder.Entity<CharacterClassesTraits>()
                .HasOne(cct => cct.CharacterClass)
                .WithMany(cc => cc.CharacterClassesTraits)
                .HasForeignKey(cct => cct.CharacterClassId);

            builder.Entity<CharacterClassLanguages>().HasKey(ccs => new { ccs.LanguageId, ccs.CharacterClassId });

            builder.Entity<CharacterClassLanguages>()
                .HasOne(ccl => ccl.Language)
                .WithMany(l => l.CharacterClassLanguages)
                .HasForeignKey(ccl => ccl.LanguageId);

            builder.Entity<CharacterClassLanguages>()
                .HasOne(ccl => ccl.CharacterClass)
                .WithMany(cc => cc.CharacterClassLanguages)
                .HasForeignKey(ccl => ccl.CharacterClassId);

            builder.Entity<RaceTraits>().HasKey(rt => new { rt.RaceId, rt.TraitId });

            builder.Entity<RaceTraits>()
                .HasOne(rt => rt.Race)
                .WithMany(r => r.RaceTraits)
                .HasForeignKey(rt => rt.RaceId);

            builder.Entity<RaceTraits>()
                .HasOne(rt => rt.Trait)
                .WithMany(t => t.RaceTraits)
                .HasForeignKey(rt => rt.TraitId);

            builder.Entity<RacesLanguages>().HasKey(rl => new { rl.LanguageId, rl.RaceId });

            builder.Entity<RacesLanguages>()
                .HasOne(rl => rl.Language)
                .WithMany(l => l.RacesLanguages)
                .HasForeignKey(rl => rl.LanguageId);

            builder.Entity<RacesLanguages>()
                .HasOne(rl => rl.Race)
                .WithMany(r => r.RacesLanguages)
                .HasForeignKey(rl => rl.RaceId);

            builder.Entity<CharacterClassesAbilities>().HasKey(cca => new { cca.AbilityId, cca.CharacterClassId });

            builder.Entity<CharacterClassesAbilities>()
                .HasOne(cca => cca.CharacterClass)
                .WithMany(cc => cc.CharacterClassesAbilities)
                .HasForeignKey(cca => cca.CharacterClassId);

            builder.Entity<CharacterClassesAbilities>()
                .HasOne(cca => cca.Ability)
                .WithMany(a => a.CharacterClassesAbilities)
                .HasForeignKey(cca => cca.AbilityId);

            ApplicationUserSeeder.Seed(builder);
            InventorySeeder.Seed(builder);
            CharacterSeeder.Seed(builder);
            CharacterSpellSeeder.Seed(builder);
            InventoryArmorSeeder.Seed(builder);
            InventoryPotionsSeeder.Seed(builder);
            InventoryWeaponSeeder.Seed(builder);
            RaceSeeder.Seed(builder);
            AbilitySeeder.Seed(builder);
            CharacterClassSeeder.Seed(builder);
            CharacterClassesSeeder.Seed(builder);
            TraitSeeder.Seed(builder);
            LanguageSeeder.Seed(builder);
            RacesTraitsSeeder.Seed(builder);
            RaceLanguageSeeder.Seed(builder);
            CharactersRacesSeeder.Seed(builder);
            CharacterClassesAbilitiesSeeder.Seed(builder);
            CharacterClassesTraitsSeeder.Seed(builder);
            ApplicationRoleSeeder.Seed(builder);
            ApplicationUsersRolesSeeder.Seed(builder);
        }

        #endregion Protected Methods
    }
}