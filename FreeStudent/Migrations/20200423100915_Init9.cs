using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_File_Forum_ForumId",
                table: "File");

            migrationBuilder.DropForeignKey(
                name: "FK_File_ForumMessage_ForumMessageId",
                table: "File");

            migrationBuilder.DropForeignKey(
                name: "FK_File_UserProfile_UserProfileId",
                table: "File");

            migrationBuilder.DropPrimaryKey(
                name: "PK_File",
                table: "File");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "File");

            migrationBuilder.RenameTable(
                name: "File",
                newName: "Files");

            migrationBuilder.RenameIndex(
                name: "IX_File_UserProfileId",
                table: "Files",
                newName: "IX_Files_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_File_ForumMessageId",
                table: "Files",
                newName: "IX_Files_ForumMessageId");

            migrationBuilder.RenameIndex(
                name: "IX_File_ForumId",
                table: "Files",
                newName: "IX_Files_ForumId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Files",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Forum_ForumId",
                table: "Files",
                column: "ForumId",
                principalTable: "Forum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_ForumMessage_ForumMessageId",
                table: "Files",
                column: "ForumMessageId",
                principalTable: "ForumMessage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_UserProfile_UserProfileId",
                table: "Files",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Forum_ForumId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_ForumMessage_ForumMessageId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_UserProfile_UserProfileId",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "File");

            migrationBuilder.RenameIndex(
                name: "IX_Files_UserProfileId",
                table: "File",
                newName: "IX_File_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_ForumMessageId",
                table: "File",
                newName: "IX_File_ForumMessageId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_ForumId",
                table: "File",
                newName: "IX_File_ForumId");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "File",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_File",
                table: "File",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_File_Forum_ForumId",
                table: "File",
                column: "ForumId",
                principalTable: "Forum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_File_ForumMessage_ForumMessageId",
                table: "File",
                column: "ForumMessageId",
                principalTable: "ForumMessage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_File_UserProfile_UserProfileId",
                table: "File",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
