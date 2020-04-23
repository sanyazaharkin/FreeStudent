using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserProfileId = table.Column<Guid>(nullable: false),
                    bytes = table.Column<byte[]>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    ForumId = table.Column<Guid>(nullable: true),
                    ForumMessageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.Id);
                    table.ForeignKey(
                        name: "FK_File_Forum_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_File_ForumMessage_ForumMessageId",
                        column: x => x.ForumMessageId,
                        principalTable: "ForumMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_File_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_File_ForumId",
                table: "File",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_File_ForumMessageId",
                table: "File",
                column: "ForumMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_File_UserProfileId",
                table: "File",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "File");
        }
    }
}
