using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SKPBlogEngine.Web.Migrations
{
    public partial class memberpropertylastlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDate",
                table: "Member",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "Member");
        }
    }
}
