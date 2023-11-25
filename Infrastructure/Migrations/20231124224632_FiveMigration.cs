using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class FiveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rank_Category");

            migrationBuilder.AddColumn<long>(
                name: "categoryId",
                table: "Unit",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "rankId",
                table: "Unit",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Unit_categoryId",
                table: "Unit",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_rankId",
                table: "Unit",
                column: "rankId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Category_categoryId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Rank_rankId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_categoryId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_rankId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "rankId",
                table: "Unit");

            migrationBuilder.CreateTable(
                name: "Rank_Category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    RankId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserModification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rank_Category_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rank_Category_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rank_Category_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rank_Category_CategoryId",
                table: "Rank_Category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_Category_RankId",
                table: "Rank_Category",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_Category_UnitId",
                table: "Rank_Category",
                column: "UnitId",
                unique: true);
        }
    }
}
