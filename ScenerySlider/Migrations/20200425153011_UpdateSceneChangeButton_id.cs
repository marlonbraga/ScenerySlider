using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class UpdateSceneChangeButton_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneDestinationId",
                table: "SceneButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_SceneDestinationId",
                table: "SceneButtons");

            migrationBuilder.DropColumn(
                name: "SceneDestinationId",
                table: "SceneButtons");

            migrationBuilder.AddColumn<int>(
                name: "SceneId",
                table: "SceneButtons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_SceneId",
                table: "SceneButtons",
                column: "SceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneButtons",
                column: "SceneId",
                principalTable: "Scenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneId",
                table: "SceneButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_SceneId",
                table: "SceneButtons");

            migrationBuilder.DropColumn(
                name: "SceneId",
                table: "SceneButtons");

            migrationBuilder.AddColumn<int>(
                name: "SceneDestinationId",
                table: "SceneButtons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_SceneDestinationId",
                table: "SceneButtons",
                column: "SceneDestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_SceneDestinationId",
                table: "SceneButtons",
                column: "SceneDestinationId",
                principalTable: "Scenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
