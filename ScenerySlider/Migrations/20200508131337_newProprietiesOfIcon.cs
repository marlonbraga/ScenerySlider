using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class newProprietiesOfIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SceneButtons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "InformationSpotButtons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "SceneButtons");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "InformationSpotButtons");
        }
    }
}
