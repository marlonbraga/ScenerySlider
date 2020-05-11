using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class newProprietiesOfIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SceneChangeButtons",
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
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "InformationSpotButtons");
        }
    }
}
