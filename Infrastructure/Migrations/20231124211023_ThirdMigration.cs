using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alliance_Alliance_AllianceId",
                table: "Alliance");

            migrationBuilder.DropForeignKey(
                name: "FK_Alliance_Country_Alliance_Country_Alliance_CountryId",
                table: "Alliance_Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Battle_Battle_BattleId",
                table: "Battle");

            migrationBuilder.DropForeignKey(
                name: "FK_ByHour_ByHour_ByHourId",
                table: "ByHour");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Country_CountryId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Faction_Faction_FactionId",
                table: "Faction");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalWar_GlobalWar_GlobalWarId",
                table: "GlobalWar");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Unit_UnitId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_UnitId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_GlobalWar_GlobalWarId",
                table: "GlobalWar");

            migrationBuilder.DropIndex(
                name: "IX_Faction_FactionId",
                table: "Faction");

            migrationBuilder.DropIndex(
                name: "IX_Country_CountryId",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_ByHour_ByHourId",
                table: "ByHour");

            migrationBuilder.DropIndex(
                name: "IX_Battle_BattleId",
                table: "Battle");

            migrationBuilder.DropIndex(
                name: "IX_Alliance_Country_Alliance_CountryId",
                table: "Alliance_Country");

            migrationBuilder.DropIndex(
                name: "IX_Alliance_AllianceId",
                table: "Alliance");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "GlobalWarId",
                table: "GlobalWar");

            migrationBuilder.DropColumn(
                name: "FactionId",
                table: "Faction");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ByHourId",
                table: "ByHour");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "Alliance_CountryId",
                table: "Alliance_Country");

            migrationBuilder.DropColumn(
                name: "AllianceId",
                table: "Alliance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UnitId",
                table: "Unit",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "GlobalWarId",
                table: "GlobalWar",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FactionId",
                table: "Faction",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Country",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ByHourId",
                table: "ByHour",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BattleId",
                table: "Battle",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Alliance_CountryId",
                table: "Alliance_Country",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AllianceId",
                table: "Alliance",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unit_UnitId",
                table: "Unit",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalWar_GlobalWarId",
                table: "GlobalWar",
                column: "GlobalWarId");

            migrationBuilder.CreateIndex(
                name: "IX_Faction_FactionId",
                table: "Faction",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CountryId",
                table: "Country",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ByHour_ByHourId",
                table: "ByHour",
                column: "ByHourId");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleId",
                table: "Battle",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Alliance_Country_Alliance_CountryId",
                table: "Alliance_Country",
                column: "Alliance_CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Alliance_AllianceId",
                table: "Alliance",
                column: "AllianceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alliance_Alliance_AllianceId",
                table: "Alliance",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alliance_Country_Alliance_Country_Alliance_CountryId",
                table: "Alliance_Country",
                column: "Alliance_CountryId",
                principalTable: "Alliance_Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_Battle_BattleId",
                table: "Battle",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ByHour_ByHour_ByHourId",
                table: "ByHour",
                column: "ByHourId",
                principalTable: "ByHour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Country_CountryId",
                table: "Country",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Faction_Faction_FactionId",
                table: "Faction",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalWar_GlobalWar_GlobalWarId",
                table: "GlobalWar",
                column: "GlobalWarId",
                principalTable: "GlobalWar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Unit_UnitId",
                table: "Unit",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
