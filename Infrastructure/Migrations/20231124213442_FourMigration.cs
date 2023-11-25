using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class FourMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UnitId",
                table: "Rank_Category",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Rank_Category_UnitId",
                table: "Rank_Category",
                column: "UnitId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rank_Category_Unit_UnitId",
                table: "Rank_Category",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rank_Category_Unit_UnitId",
                table: "Rank_Category");

            migrationBuilder.DropIndex(
                name: "IX_Rank_Category_UnitId",
                table: "Rank_Category");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Rank_Category");
        }
    }
}
