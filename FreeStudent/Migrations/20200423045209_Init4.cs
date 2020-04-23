using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SpecializationId",
                table: "Orders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PrevForumTopicId",
                table: "ForumTopic",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SpecializationId",
                table: "Orders",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_PrevForumTopicId",
                table: "ForumTopic",
                column: "PrevForumTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTopic_ForumTopic_PrevForumTopicId",
                table: "ForumTopic",
                column: "PrevForumTopicId",
                principalTable: "ForumTopic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Specialization_SpecializationId",
                table: "Orders",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_ForumTopic_PrevForumTopicId",
                table: "ForumTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Specialization_SpecializationId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SpecializationId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_ForumTopic_PrevForumTopicId",
                table: "ForumTopic");

            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PrevForumTopicId",
                table: "ForumTopic");
        }
    }
}
