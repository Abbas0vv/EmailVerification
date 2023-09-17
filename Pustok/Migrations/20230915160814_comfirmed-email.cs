using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class comfirmedemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmailConfirmed",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmailConfirmed", "Password" },
                values: new object[] { true, "$2a$11$5NybuCqbG00OIlTJ8N1vUewR/uDPe1SS6.a/h10Qu306CCUfVGDeO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEmailConfirmed",
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
