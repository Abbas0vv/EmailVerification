using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class comfirmedemailflase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmailConfirmed", "Password" },
                values: new object[] { false, "$2a$11$RymJH9RxImxoZc9fj/i4MemeSe04heGXsyZ7U/SvrE4ffZOiFSZPW" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmailConfirmed", "Password" },
                values: new object[] { true, "$2a$11$5NybuCqbG00OIlTJ8N1vUewR/uDPe1SS6.a/h10Qu306CCUfVGDeO" });
        }
    }
}
