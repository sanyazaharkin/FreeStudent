using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forum_UserProfile_UserProfileId",
                table: "Forum");

            migrationBuilder.DropIndex(
                name: "IX_Forum_UserProfileId",
                table: "Forum");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "Forum");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "RatingAndReviewsHistory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrdersHistory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Forum",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForumsUserProfilesRelationships",
                columns: table => new
                {
                    UserProfileId = table.Column<Guid>(nullable: false),
                    ForumId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumsUserProfilesRelationships", x => new { x.ForumId, x.UserProfileId });
                    table.ForeignKey(
                        name: "FK_ForumsUserProfilesRelationships_Forum_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumsUserProfilesRelationships_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumTopic",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ForumId = table.Column<Guid>(nullable: true)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_RatingAndReviewsHistory_OrderId",
                table: "RatingAndReviewsHistory",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersHistory_OrderId",
                table: "OrdersHistory",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Forum_OrderId",
                table: "Forum",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumsUserProfilesRelationships_UserProfileId",
                table: "ForumsUserProfilesRelationships",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_ForumId",
                table: "ForumTopic",
                column: "ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forum_Orders_OrderId",
                table: "Forum",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersHistory_Orders_OrderId",
                table: "OrdersHistory",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RatingAndReviewsHistory_Orders_OrderId",
                table: "RatingAndReviewsHistory",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forum_Orders_OrderId",
                table: "Forum");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersHistory_Orders_OrderId",
                table: "OrdersHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RatingAndReviewsHistory_Orders_OrderId",
                table: "RatingAndReviewsHistory");

            migrationBuilder.DropTable(
                name: "ForumsUserProfilesRelationships");

            migrationBuilder.DropTable(
                name: "ForumTopic");

            migrationBuilder.DropIndex(
                name: "IX_RatingAndReviewsHistory_OrderId",
                table: "RatingAndReviewsHistory");

            migrationBuilder.DropIndex(
                name: "IX_OrdersHistory_OrderId",
                table: "OrdersHistory");

            migrationBuilder.DropIndex(
                name: "IX_Forum_OrderId",
                table: "Forum");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "RatingAndReviewsHistory");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrdersHistory");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Forum");

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfileId",
                table: "Forum",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forum_UserProfileId",
                table: "Forum",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forum_UserProfile_UserProfileId",
                table: "Forum",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
