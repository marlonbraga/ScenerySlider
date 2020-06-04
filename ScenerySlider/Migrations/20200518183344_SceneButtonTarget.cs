using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenerySlider.Migrations
{
    public partial class SceneButtonTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "OwnerSceneId",
                table: "SceneButtons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetSceneId",
                table: "SceneButtons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_OwnerSceneId",
                table: "SceneButtons",
                column: "OwnerSceneId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneChangeButtons_TargetSceneId",
                table: "SceneButtons",
                column: "TargetSceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_OwnerSceneId",
                table: "SceneButtons",
                column: "OwnerSceneId",
                principalTable: "Scenes",
                principalColumn: "SceneId");

            migrationBuilder.AddForeignKey(
                name: "FK_SceneChangeButtons_Scenes_TargetSceneId",
                table: "SceneButtons",
                column: "TargetSceneId",
                principalTable: "Scenes",
                principalColumn: "SceneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_OwnerSceneId",
                table: "SceneButtons");

            migrationBuilder.DropForeignKey(
                name: "FK_SceneChangeButtons_Scenes_TargetSceneId",
                table: "SceneButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_OwnerSceneId",
                table: "SceneButtons");

            migrationBuilder.DropIndex(
                name: "IX_SceneChangeButtons_TargetSceneId",
                table: "SceneButtons");

            migrationBuilder.DropColumn(
                name: "OwnerSceneId",
                table: "SceneButtons");

            migrationBuilder.DropColumn(
                name: "TargetSceneId",
                table: "SceneButtons");

            migrationBuilder.AddColumn<int>(
                name: "SceneId",
                table: "SceneButtons",
                type: "int",
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
                principalColumn: "SceneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
