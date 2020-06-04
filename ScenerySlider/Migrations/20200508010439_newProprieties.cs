using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class newProprieties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneButtons");

            migrationBuilder.DropForeignKey(
                name: "FK_Scenes_InformationSpotButtons_InformationSpotButtonId",
                table: "Scenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scenes",
                table: "Scenes");

            migrationBuilder.DropIndex(
                name: "IX_Scenes_InformationSpotButtonId",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "InformationSpotButtonId",
                table: "Scenes");

            migrationBuilder.AddColumn<int>(
                name: "SceneId",
                table: "Scenes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundLocation",
                table: "Scenes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Scenes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Scenes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rotation",
                table: "SceneButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rotation",
                table: "InformationSpotButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SceneId",
                table: "InformationSpotButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scenes",
                table: "Scenes",
                column: "SceneId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationSpotButtons_SceneId",
                table: "InformationSpotButtons",
                column: "SceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationSpotButtons_Scenes_SceneId",
                table: "InformationSpotButtons",
                column: "SceneId",
                principalTable: "Scenes",
                principalColumn: "SceneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneButtons",
                column: "SceneId",
                principalTable: "Scenes",
                principalColumn: "SceneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationSpotButtons_Scenes_SceneId",
                table: "InformationSpotButtons");

            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneButtons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scenes",
                table: "Scenes");

            migrationBuilder.DropIndex(
                name: "IX_InformationSpotButtons_SceneId",
                table: "InformationSpotButtons");

            migrationBuilder.DropColumn(
                name: "SceneId",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "BackgroundLocation",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "Rotation",
                table: "SceneButtons");

            migrationBuilder.DropColumn(
                name: "Rotation",
                table: "InformationSpotButtons");

            migrationBuilder.DropColumn(
                name: "SceneId",
                table: "InformationSpotButtons");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Scenes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "InformationSpotButtonId",
                table: "Scenes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scenes",
                table: "Scenes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Scenes_InformationSpotButtonId",
                table: "Scenes",
                column: "InformationSpotButtonId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneButtons",
                column: "SceneId",
                principalTable: "Scenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scenes_InformationSpotButtons_InformationSpotButtonId",
                table: "Scenes",
                column: "InformationSpotButtonId",
                principalTable: "InformationSpotButtons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
