using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SKPBlogEngine.Web.Migrations
{
    public partial class memberentitymodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Member",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Member",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistplayName",
                table: "Member",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Member",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "DistplayName",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Member");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Member",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
