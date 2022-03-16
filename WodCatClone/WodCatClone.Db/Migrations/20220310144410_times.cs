using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations
{
    public partial class times : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Workouts",
                newName: "Seconds");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "ResultWorkouts",
                newName: "Seconds");

            migrationBuilder.AddColumn<string>(
                name: "Minutes",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Minutes",
                table: "ResultWorkouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Minutes",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "Minutes",
                table: "ResultWorkouts");

            migrationBuilder.RenameColumn(
                name: "Seconds",
                table: "Workouts",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Seconds",
                table: "ResultWorkouts",
                newName: "Time");
        }
    }
}
