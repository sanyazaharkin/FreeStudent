using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumTopic");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCommissionPercentage",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tariffs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerformerCommissionPercentage",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionFee",
                table: "Tariffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ForumMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ForimId = table.Column<Guid>(nullable: false),
                    ForumId = table.Column<Guid>(nullable: true),
                    UserProfileId = table.Column<Guid>(nullable: false),
                    PrevForumTopicId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumMessage_Forum_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumMessage_ForumMessage_PrevForumTopicId",
                        column: x => x.PrevForumTopicId,
                        principalTable: "ForumMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumMessage_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessage_ForumId",
                table: "ForumMessage",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessage_PrevForumTopicId",
                table: "ForumMessage",
                column: "PrevForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessage_UserProfileId",
                table: "ForumMessage",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumMessage");

            migrationBuilder.DropColumn(
                name: "CustomerCommissionPercentage",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "PerformerCommissionPercentage",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tariffs");

            migrationBuilder.DropColumn(
                name: "SubscriptionFee",
                table: "Tariffs");

            migrationBuilder.CreateTable(
                name: "ForumTopic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ForumId = table.Column<Guid>(type: "char(36)", nullable: true),
                    PrevForumTopicId = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumTopic_Forum_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumTopic_ForumTopic_PrevForumTopicId",
                        column: x => x.PrevForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumTopic_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_ForumId",
                table: "ForumTopic",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_PrevForumTopicId",
                table: "ForumTopic",
                column: "PrevForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_UserProfileId",
                table: "ForumTopic",
                column: "UserProfileId");
        }
    }
}
