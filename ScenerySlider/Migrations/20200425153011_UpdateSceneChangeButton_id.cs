using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class UpdateSceneChangeButton_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneDestinationId",
                table: "SceneChangeButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_SceneDestinationId",
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "SceneDestinationId",
                table: "SceneChangeButtons");

            migrationBuilder.AddColumn<int>(
                name: "SceneId",
                table: "SceneChangeButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_SceneId",
                table: "SceneChangeButtons",
                column: "SceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneChangeButtons",
                column: "SceneId",
                principalTable: "Scenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_SceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "SceneId",
                table: "SceneChangeButtons");

            migrationBuilder.AddColumn<int>(
                name: "SceneDestinationId",
                table: "SceneChangeButtons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_SceneDestinationId",
                table: "SceneChangeButtons",
                column: "SceneDestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneDestinationId",
                table: "SceneChangeButtons",
                column: "SceneDestinationId",
                principalTable: "Scenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
