using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations
{
    public partial class nullabe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_HallEmblem_EmblemHallId",
                table: "Halls");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_HallEmblem_EmblemHallId",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "EmblemHallId",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmblemHallId",
                table: "Halls",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_HallEmblem_EmblemHallId",
                table: "Halls",
                column: "EmblemHallId",
                principalTable: "HallEmblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_HallEmblem_EmblemHallId",
                table: "Workouts",
                column: "EmblemHallId",
                principalTable: "HallEmblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_HallEmblem_EmblemHallId",
                table: "Halls");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_HallEmblem_EmblemHallId",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "EmblemHallId",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmblemHallId",
                table: "Halls",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_HallEmblem_EmblemHallId",
                table: "Halls",
                column: "EmblemHallId",
                principalTable: "HallEmblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_HallEmblem_EmblemHallId",
                table: "Workouts",
                column: "EmblemHallId",
                principalTable: "HallEmblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
