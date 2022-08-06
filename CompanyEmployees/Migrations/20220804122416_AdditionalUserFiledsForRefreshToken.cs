using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class AdditionalUserFiledsForRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c068d5c-9fd8-41a0-bf0e-7551402e30d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba148673-807f-4852-a2ed-e0dcaf079521");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1384872c-c125-4079-aa7d-bdf577586ba8", "b6a3644f-9df4-43c1-b2e9-67faf75ce486", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed74103a-6270-47c1-8fbc-9801dbba437f", "a1b6bc27-d3d3-4865-b42e-99bfe163d5c4", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1384872c-c125-4079-aa7d-bdf577586ba8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed74103a-6270-47c1-8fbc-9801dbba437f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c068d5c-9fd8-41a0-bf0e-7551402e30d6", "541f60f6-5047-45c8-9108-6df22975dcc5", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba148673-807f-4852-a2ed-e0dcaf079521", "153ac0a1-6531-4cc6-918a-6245057d176d", "Administrator", "ADMINISTRATOR" });
        }
    }
}
