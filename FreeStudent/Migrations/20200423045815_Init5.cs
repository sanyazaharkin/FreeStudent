using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserProfileId",
                table: "ForumTopic",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_UserProfileId",
                table: "ForumTopic",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTopic_UserProfile_UserProfileId",
                table: "ForumTopic",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_UserProfile_UserProfileId",
                table: "ForumTopic");

            migrationBuilder.DropIndex(
                name: "IX_ForumTopic_UserProfileId",
                table: "ForumTopic");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "ForumTopic");
        }
    }
}
