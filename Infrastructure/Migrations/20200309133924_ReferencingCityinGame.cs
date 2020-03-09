using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ReferencingCityinGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Games",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Games_CityId",
                table: "Games",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Cities_CityId",
                table: "Games",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Cities_CityId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CityId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Games");
        }
    }
}
