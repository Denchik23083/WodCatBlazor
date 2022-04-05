using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations
{
    public partial class relation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmblemHallId",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_EmblemHallId",
                table: "Workouts",
                column: "EmblemHallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_HallEmblem_EmblemHallId",
                table: "Workouts",
                column: "EmblemHallId",
                principalTable: "HallEmblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_HallEmblem_EmblemHallId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_EmblemHallId",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "EmblemHallId",
                table: "Workouts");
        }
    }
}
