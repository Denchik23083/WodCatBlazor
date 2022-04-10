using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations
{
    public partial class relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmblemHallId",
                table: "Halls",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Halls_EmblemHallId",
                table: "Halls",
                column: "EmblemHallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_HallEmblem_EmblemHallId",
                table: "Halls",
                column: "EmblemHallId",
                principalTable: "HallEmblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_HallEmblem_EmblemHallId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_EmblemHallId",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "EmblemHallId",
                table: "Halls");
        }
    }
}
