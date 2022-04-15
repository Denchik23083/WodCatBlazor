using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations
{
    public partial class CountAthletes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HallId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Athletes",
                table: "Halls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_HallId",
                table: "Users",
                column: "HallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Halls_HallId",
                table: "Users",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Halls_HallId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_HallId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Athletes",
                table: "Halls");
        }
    }
}
