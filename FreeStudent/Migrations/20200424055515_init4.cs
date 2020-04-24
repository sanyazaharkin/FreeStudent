using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeStudent.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfDownload",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfMarkForDelete",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "MarkedForDeletion",
                table: "Files",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfDownload",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "DateOfMarkForDelete",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "MarkedForDeletion",
                table: "Files");
        }
    }
}
