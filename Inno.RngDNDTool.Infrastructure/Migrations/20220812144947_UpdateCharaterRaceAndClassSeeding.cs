using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharaterRaceAndClassSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_CharacterClasses_CharacterClassId",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersClasses_CharacterClasses_CharacterClassId",
                table: "CharactersClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersClasses_Characters_CharacterClassId",
                table: "CharactersClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcClasses_CharacterClasses_CharacterClassId",
                table: "NpcClasses");

            migrationBuilder.DropIndex(
                name: "IX_Abilities_CharacterClassId",
                table: "Abilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterClasses",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "CharacterClassId",
                table: "Abilities");

            migrationBuilder.RenameTable(
                name: "CharacterClasses",
                newName: "Proficiencies");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "WeaponProficiencies",
                table: "Proficiencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Proficiencies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Proficiencies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ArmorProficiencies",
                table: "Proficiencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proficiencies",
                table: "Proficiencies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CharacterClassesAbilities",
                columns: table => new
                {
                    CharacterClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AbilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClassesAbilities", x => new { x.AbilityId, x.CharacterClassId });
                    table.ForeignKey(
                        name: "FK_CharacterClassesAbilities_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClassesAbilities_Proficiencies_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allignment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trait",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trait", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClassLanguages",
                columns: table => new
                {
                    CharacterClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClassLanguages", x => new { x.LanguageId, x.CharacterClassId });
                    table.ForeignKey(
                        name: "FK_CharacterClassLanguages_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClassLanguages_Proficiencies_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterRaces",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRaces", x => new { x.RaceId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterRaces_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterRaces_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RacesLanguages",
                columns: table => new
                {
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacesLanguages", x => new { x.LanguageId, x.RaceId });
                    table.ForeignKey(
                        name: "FK_RacesLanguages_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacesLanguages_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClassesTraits",
                columns: table => new
                {
                    CharacterClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TraitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClassesTraits", x => new { x.TraitId, x.CharacterClassId });
                    table.ForeignKey(
                        name: "FK_CharacterClassesTraits_Proficiencies_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClassesTraits_Trait_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Trait",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceTraits",
                columns: table => new
                {
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TraitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTraits", x => new { x.RaceId, x.TraitId });
                    table.ForeignKey(
                        name: "FK_RaceTraits_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceTraits_Trait_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Trait",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Description", "Name", "RequiredLevel" },
                values: new object[,]
                {
                    { new Guid("2fd61669-da9a-4e7f-9526-4ba764d8dcc5"), "At 1st level, your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons, which are shortswords and any simple melee weapons that don’t have the two-handed or heavy property.You gain the following benefits while you are unarmed or wielding only monk weapons and you aren’t wearing armor or wielding a shield: You can use Dexterity instead of Strength for the attack and damage rolls of your unarmed strikes and monk weapons. You can roll a d4 in place of the normal damage of your unarmed strike or monk weapon.This die changes as you gain monk levels, as shown in the Martial Arts column of the Monk table. When you use the Attack action with an unarmed strike or a monk weapon on your turn, you can make one unarmed strike as a bonus action.For example, if you take the Attack action and attack with a quarterstaff, you can also make an unarmed strike as a bonus action, assuming you haven’t already taken a bonus action this turn.", "Martial Arts", 1 },
                    { new Guid("872f8b39-f29f-4e2e-ba7f-38a03ef6beb0"), "Beginning at 1st level, while you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.", "Unarmored Defense", 0 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67e88e54-6495-4ad8-88a1-2117a5eccac3", "AQAAAAEAACcQAAAAEG4pbGbB5hkz55RHZFlawKDqhI//u8IkbvIiQJo7T/u3+XKz/BiwQ01Po1pc4QnbDQ==", "f6057741-eb7b-404a-8a4d-95bd89aaad62" });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d0d5ee32-2be6-4e23-ad46-62af79029e27"), "You can speak, read, and write Common Tongue", "Common Tongue" },
                    { new Guid("d382a917-c2a4-48a6-9529-81b24aae44a1"), "You can speak, read, and write Grung.", "Grung" }
                });

            migrationBuilder.InsertData(
                table: "Proficiencies",
                columns: new[] { "Id", "ArmorProficiencies", "Description", "Discriminator", "HitDice", "HitPoints", "Name", "WeaponProficiencies" },
                values: new object[] { new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523"), 2, "Whatever their discipline, monks are united in their ability to magically harness the energy that flows in their bodies. Whether channeled as a striking display of combat prowess or a subtler focus of defensive ability and speed, this energy infuses all that a monk does.", "CharacterClass", 8, 8, "Monk", 0 });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "Id", "Allignment", "Description", "Name" },
                values: new object[] { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), "Alignment. Most grungs are lawful, having been raised in a strict caste system. They tend toward evil as well, coming from a culture where social advancement occurs rarely, and most often because another member of your army has died and there is no one else of that caste to fill the vacancy.", "Grungs are aggressive froglike humanoids found in rain forests and tropical jungles. They are fiercely territorial and see themselves as superior to most other creatures.Grung society is a caste system. Each caste lays eggs in a separate hatching pool, and juvenile grungs join their caste upon emergence from the hatchery. All grungs are a dull greenish gray when they are born, but each individual takes on the color of its caste as it grows to adulthood. From lowest to highest caste, grungs can be green, blue, purple, red, orange, or gold.", "Grung" });

            migrationBuilder.InsertData(
                table: "Trait",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0e1ca1b6-02e8-4c99-9e96-0c4c8fba046a"), "You have proficiency in the Perception skill.", "Arboreal Alertness" },
                    { new Guid("184bc475-d47d-4e0f-a467-771298b01c68"), "Grungs stand between 2 ½ and 3 ½ feet tall and average about 30 pounds. Your size is Small.", "Size Grung" },
                    { new Guid("18d497dd-927a-4896-8844-0788118b818b"), "Your long jump is up to 25 feet and your high jump is up to 15 feet, with or without a running start.", "Standing Leap" },
                    { new Guid("5256ab96-926d-4f40-a1fe-cc33660042c3"), "Your Dexterity score increases by 2 and your Constitution score increases by 1.", "Ability Score Increase" },
                    { new Guid("ba06c2e8-2f32-48ba-bd1e-32c625ecd3d3"), "Any creature that grapples you or otherwise comes into direct contact with your skin must succeed on a DC 12 Constitution saving throw or become poisoned for 1 minute. A poisoned creature no longer in direct contact with you can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.You can also apply this poison to any piercing weapon as part of an attack with that weapon, though when you hit the poison reacts differently. The target must succeed on a DC 12 Constitution saving throw or take 2d4 poison damage.", "Poisonous Skin" },
                    { new Guid("c47f9f76-d53d-4fca-95dd-6c41cd1676f8"), "You can breathe air and water.", "Amphibious" },
                    { new Guid("cb0b5963-cf5f-41e8-92df-9dee989009e2"), "If you fail to immerse yourself in water for at least 1 hour during a day, you suffer 1 level of exhaustion at the end of that day. You can recover from this exhaustion only through magic or by immersing yourself in water for at least 1 hour.", "Water Dependency" },
                    { new Guid("d6d14ba3-d038-4322-9296-e9b5a4dcfd5c"), "Grungs mature to adulthood in a single year, but have been known to live up to 50 years.", "Age Grung" },
                    { new Guid("e0fc2d4d-127c-49bf-a170-ca3290d90eef"), "You are immune to poison damage and the poisoned condition.", "Poison Immunity" },
                    { new Guid("f3311af6-7b91-4071-b88a-b71c7758217d"), "Three traditions of monastic pursuit are common in the monasteries scattered across the multiverse. Most monasteries practice one tradition exclusively, but a few honor the three traditions and instruct each monk according to his or her aptitude and interest. All three traditions rely on the same basic techniques, diverging as the student grows more adept. Thus, a monk need choose a tradition only upon reaching 3rd level.", "Monastic Traditions" }
                });

            migrationBuilder.InsertData(
                table: "CharacterClassesAbilities",
                columns: new[] { "AbilityId", "CharacterClassId" },
                values: new object[,]
                {
                    { new Guid("2fd61669-da9a-4e7f-9526-4ba764d8dcc5"), new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523") },
                    { new Guid("872f8b39-f29f-4e2e-ba7f-38a03ef6beb0"), new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523") }
                });

            migrationBuilder.InsertData(
                table: "CharacterClassesTraits",
                columns: new[] { "CharacterClassId", "TraitId" },
                values: new object[] { new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523"), new Guid("f3311af6-7b91-4071-b88a-b71c7758217d") });

            migrationBuilder.InsertData(
                table: "CharactersClasses",
                columns: new[] { "CharacterClassId", "CharacterId" },
                values: new object[] { new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523"), new Guid("29bcd574-1436-4a71-a750-4484d10cb105") });

            migrationBuilder.InsertData(
                table: "RaceTraits",
                columns: new[] { "RaceId", "TraitId" },
                values: new object[,]
                {
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("0e1ca1b6-02e8-4c99-9e96-0c4c8fba046a") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("184bc475-d47d-4e0f-a467-771298b01c68") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("18d497dd-927a-4896-8844-0788118b818b") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("5256ab96-926d-4f40-a1fe-cc33660042c3") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("ba06c2e8-2f32-48ba-bd1e-32c625ecd3d3") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("c47f9f76-d53d-4fca-95dd-6c41cd1676f8") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("cb0b5963-cf5f-41e8-92df-9dee989009e2") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("d6d14ba3-d038-4322-9296-e9b5a4dcfd5c") },
                    { new Guid("97398aed-9dd3-48b3-9689-9dd455db396f"), new Guid("e0fc2d4d-127c-49bf-a170-ca3290d90eef") }
                });

            migrationBuilder.InsertData(
                table: "RacesLanguages",
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[,]
                {
                    { new Guid("d0d5ee32-2be6-4e23-ad46-62af79029e27"), new Guid("97398aed-9dd3-48b3-9689-9dd455db396f") },
                    { new Guid("d382a917-c2a4-48a6-9529-81b24aae44a1"), new Guid("97398aed-9dd3-48b3-9689-9dd455db396f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharactersClasses_CharacterId",
                table: "CharactersClasses",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClassesAbilities_CharacterClassId",
                table: "CharacterClassesAbilities",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClassesTraits_CharacterClassId",
                table: "CharacterClassesTraits",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClassLanguages_CharacterClassId",
                table: "CharacterClassLanguages",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRaces_CharacterId",
                table: "CharacterRaces",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_RacesLanguages_RaceId",
                table: "RacesLanguages",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTraits_TraitId",
                table: "RaceTraits",
                column: "TraitId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersClasses_Characters_CharacterId",
                table: "CharactersClasses",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersClasses_Proficiencies_CharacterClassId",
                table: "CharactersClasses",
                column: "CharacterClassId",
                principalTable: "Proficiencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcClasses_Proficiencies_CharacterClassId",
                table: "NpcClasses",
                column: "CharacterClassId",
                principalTable: "Proficiencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharactersClasses_Characters_CharacterId",
                table: "CharactersClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersClasses_Proficiencies_CharacterClassId",
                table: "CharactersClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_NpcClasses_Proficiencies_CharacterClassId",
                table: "NpcClasses");

            migrationBuilder.DropTable(
                name: "CharacterClassesAbilities");

            migrationBuilder.DropTable(
                name: "CharacterClassesTraits");

            migrationBuilder.DropTable(
                name: "CharacterClassLanguages");

            migrationBuilder.DropTable(
                name: "CharacterRaces");

            migrationBuilder.DropTable(
                name: "RacesLanguages");

            migrationBuilder.DropTable(
                name: "RaceTraits");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Trait");

            migrationBuilder.DropIndex(
                name: "IX_CharactersClasses_CharacterId",
                table: "CharactersClasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proficiencies",
                table: "Proficiencies");

            migrationBuilder.DeleteData(
                table: "CharactersClasses",
                keyColumns: new[] { "CharacterClassId", "CharacterId" },
                keyValues: new object[] { new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523"), new Guid("29bcd574-1436-4a71-a750-4484d10cb105") });

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: new Guid("2fd61669-da9a-4e7f-9526-4ba764d8dcc5"));

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: new Guid("872f8b39-f29f-4e2e-ba7f-38a03ef6beb0"));

            migrationBuilder.DeleteData(
                table: "Proficiencies",
                keyColumn: "Id",
                keyValue: new Guid("776c058d-0aa4-4051-a9d9-18438b4a3523"));

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Proficiencies",
                newName: "CharacterClasses");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterClassId",
                table: "Abilities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WeaponProficiencies",
                table: "CharacterClasses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CharacterClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CharacterClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArmorProficiencies",
                table: "CharacterClasses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterClasses",
                table: "CharacterClasses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbade729-8f0c-45cd-9275-b3f26adfa44e", "AQAAAAEAACcQAAAAEMoJXpiLY6bkuwBTlsP28ivaFvr5Kh9/IvEFK3xxwjNdDqAaw9CLoBRBQmFcXfuMsQ==", "a9a899fa-2668-429a-a56c-f7de30c68289" });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_CharacterClassId",
                table: "Abilities",
                column: "CharacterClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abilities_CharacterClasses_CharacterClassId",
                table: "Abilities",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersClasses_CharacterClasses_CharacterClassId",
                table: "CharactersClasses",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersClasses_Characters_CharacterClassId",
                table: "CharactersClasses",
                column: "CharacterClassId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NpcClasses_CharacterClasses_CharacterClassId",
                table: "NpcClasses",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
