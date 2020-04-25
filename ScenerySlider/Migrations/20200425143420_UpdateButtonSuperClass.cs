using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class UpdateButtonSuperClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationSpotButtons_InformationSpots_InformationId",
                table: "InformationSpotButtons");

            migrationBuilder.DropIndex(
                name: "IX_InformationSpotButtons_InformationId",
                table: "InformationSpotButtons");

            migrationBuilder.DropColumn(
                name: "InformationId",
                table: "InformationSpotButtons");

            migrationBuilder.AddColumn<int>(
                name: "PositionX",
                table: "SceneChangeButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionY",
                table: "SceneChangeButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InformationSpotId",
                table: "InformationSpotButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionX",
                table: "InformationSpotButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionY",
                table: "InformationSpotButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InformationSpotButtons_InformationSpotId",
                table: "InformationSpotButtons",
                column: "InformationSpotId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationSpotButtons_InformationSpots_InformationSpotId",
                table: "InformationSpotButtons",
                column: "InformationSpotId",
                principalTable: "InformationSpots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationSpotButtons_InformationSpots_InformationSpotId",
                table: "InformationSpotButtons");

            migrationBuilder.DropIndex(
                name: "IX_InformationSpotButtons_InformationSpotId",
                table: "InformationSpotButtons");

            migrationBuilder.DropColumn(
                name: "PositionX",
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "PositionY",
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "InformationSpotId",
                table: "InformationSpotButtons");

            migrationBuilder.DropColumn(
                name: "PositionX",
                table: "InformationSpotButtons");

            migrationBuilder.DropColumn(
                name: "PositionY",
                table: "InformationSpotButtons");

            migrationBuilder.AddColumn<int>(
                name: "InformationId",
                table: "InformationSpotButtons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InformationSpotButtons_InformationId",
                table: "InformationSpotButtons",
                column: "InformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationSpotButtons_InformationSpots_InformationId",
                table: "InformationSpotButtons",
                column: "InformationId",
                principalTable: "InformationSpots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
