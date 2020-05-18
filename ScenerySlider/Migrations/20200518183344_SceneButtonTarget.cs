using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class SceneButtonTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "OwnerSceneId",
                table: "SceneChangeButtons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetSceneId",
                table: "SceneChangeButtons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_OwnerSceneId",
                table: "SceneChangeButtons",
                column: "OwnerSceneId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_TargetSceneId",
                table: "SceneChangeButtons",
                column: "TargetSceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_OwnerSceneId",
                table: "SceneChangeButtons",
                column: "OwnerSceneId",
                principalTable: "Scenes",
                principalColumn: "SceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_TargetSceneId",
                table: "SceneChangeButtons",
                column: "TargetSceneId",
                principalTable: "Scenes",
                principalColumn: "SceneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_OwnerSceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_TargetSceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_OwnerSceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_TargetSceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "OwnerSceneId",
                table: "SceneChangeButtons");

            migrationBuilder.DropColumn(
                name: "TargetSceneId",
                table: "SceneChangeButtons");

            migrationBuilder.AddColumn<int>(
                name: "SceneId",
                table: "SceneChangeButtons",
                type: "int",
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
                principalColumn: "SceneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
