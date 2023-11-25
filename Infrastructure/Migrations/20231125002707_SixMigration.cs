using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class SixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Category_categoryId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Rank_rankId",
                table: "Unit");

            migrationBuilder.DropTable(
                name: "Alliance_Country");

            migrationBuilder.RenameColumn(
                name: "rankId",
                table: "Unit",
                newName: "RankId");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Unit",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_rankId",
                table: "Unit",
                newName: "IX_Unit_RankId");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_categoryId",
                table: "Unit",
                newName: "IX_Unit_CategoryId");

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Unit",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "FactionId",
                table: "Unit",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "GlobalWarId",
                table: "Battle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Battle_ByHour",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BattleId = table.Column<long>(type: "bigint", nullable: false),
                    ByHourId = table.Column<long>(type: "bigint", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle_ByHour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Battle_ByHour_Battle_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Battle_ByHour_ByHour_ByHourId",
                        column: x => x.ByHourId,
                        principalTable: "ByHour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country_Alliance",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    AllianceId = table.Column<long>(type: "bigint", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country_Alliance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Alliance_Alliance_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Country_Alliance_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country_Battle",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    BattleId = table.Column<long>(type: "bigint", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country_Battle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Battle_Battle_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Country_Battle_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faction_ByHour",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactionId = table.Column<long>(type: "bigint", nullable: false),
                    ByHourId = table.Column<long>(type: "bigint", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faction_ByHour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faction_ByHour_ByHour_ByHourId",
                        column: x => x.ByHourId,
                        principalTable: "ByHour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faction_ByHour_Faction_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Faction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unit_Battle",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    BattleId = table.Column<long>(type: "bigint", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Battle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Battle_Battle_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unit_Battle_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Unit_CountryId",
                table: "Unit",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_FactionId",
                table: "Unit",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_GlobalWarId",
                table: "Battle",
                column: "GlobalWarId");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_ByHour_BattleId",
                table: "Battle_ByHour",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_ByHour_ByHourId",
                table: "Battle_ByHour",
                column: "ByHourId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Alliance_AllianceId",
                table: "Country_Alliance",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Alliance_CountryId",
                table: "Country_Alliance",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Battle_BattleId",
                table: "Country_Battle",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Battle_CountryId",
                table: "Country_Battle",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Faction_ByHour_ByHourId",
                table: "Faction_ByHour",
                column: "ByHourId");

            migrationBuilder.CreateIndex(
                name: "IX_Faction_ByHour_FactionId",
                table: "Faction_ByHour",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Battle_BattleId",
                table: "Unit_Battle",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Battle_UnitId",
                table: "Unit_Battle",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_GlobalWar_GlobalWarId",
                table: "Battle",
                column: "GlobalWarId",
                principalTable: "GlobalWar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Category_CategoryId",
                table: "Unit",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Country_CountryId",
                table: "Unit",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Faction_FactionId",
                table: "Unit",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Rank_RankId",
                table: "Unit",
                column: "RankId",
                principalTable: "Rank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_GlobalWar_GlobalWarId",
                table: "Battle");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Category_CategoryId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Country_CountryId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Faction_FactionId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Rank_RankId",
                table: "Unit");

            migrationBuilder.DropTable(
                name: "Battle_ByHour");

            migrationBuilder.DropTable(
                name: "Country_Alliance");

            migrationBuilder.DropTable(
                name: "Country_Battle");

            migrationBuilder.DropTable(
                name: "Faction_ByHour");

            migrationBuilder.DropTable(
                name: "Unit_Battle");

            migrationBuilder.DropIndex(
                name: "IX_Unit_CountryId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_FactionId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Battle_GlobalWarId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "FactionId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "GlobalWarId",
                table: "Battle");

            migrationBuilder.RenameColumn(
                name: "RankId",
                table: "Unit",
                newName: "rankId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Unit",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_RankId",
                table: "Unit",
                newName: "IX_Unit_rankId");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_CategoryId",
                table: "Unit",
                newName: "IX_Unit_categoryId");

            migrationBuilder.CreateTable(
                name: "Alliance_Country",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllianceId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alliance_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alliance_Country_Alliance_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alliance_Country_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alliance_Country_AllianceId",
                table: "Alliance_Country",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Alliance_Country_CountryId",
                table: "Alliance_Country",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Category_categoryId",
                table: "Unit",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Rank_rankId",
                table: "Unit",
                column: "rankId",
                principalTable: "Rank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
