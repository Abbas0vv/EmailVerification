using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class add_user_tokens_properyies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmToken",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerificateEmail",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "$2a$11$hXPTSa5MTWYvgb58lG9MrOMQzhEK1DHFfW2CHfD4dwHJF7Gb.TUfm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsVerificateEmail",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "$2a$11$pO0ZJKNjK.0MQayV7RZ6x.gP0eCOrBxGdO0Txo27wEwzwjmjPqw3y");
        }
    }
}
