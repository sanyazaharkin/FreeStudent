using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SurName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Anonymous",
                table: "UserProfile",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "Avatar",
                table: "UserProfile",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "UserProfile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastTimeOnline",
                table: "UserProfile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserProfile",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpecializationId",
                table: "UserProfile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "UserProfile",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TimeZone",
                table: "UserProfile",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserProfileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forum",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserProfileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forum_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserProfileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersHistory_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RatingAndReviewsHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserProfileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingAndReviewsHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RatingAndReviewsHistory_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_SpecializationId",
                table: "UserProfile",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_UserProfileId",
                table: "Chat",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Forum_UserProfileId",
                table: "Forum",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersHistory_UserProfileId",
                table: "OrdersHistory",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingAndReviewsHistory_UserProfileId",
                table: "RatingAndReviewsHistory",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_Specialization_SpecializationId",
                table: "UserProfile",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_Specialization_SpecializationId",
                table: "UserProfile");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Forum");

            migrationBuilder.DropTable(
                name: "OrdersHistory");

            migrationBuilder.DropTable(
                name: "RatingAndReviewsHistory");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DropIndex(
                name: "IX_UserProfile_SpecializationId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "Anonymous",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "LastTimeOnline",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "SurName",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "UserProfile");

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
