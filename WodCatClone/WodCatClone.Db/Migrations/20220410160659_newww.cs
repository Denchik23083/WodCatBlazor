using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations
{
    public partial class newww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Halls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Halls_UserId",
                table: "Halls",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Users_UserId",
                table: "Halls",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Users_UserId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_UserId",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Halls");
        }
    }
}
