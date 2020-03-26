using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Migrations
{
    public partial class addingeventtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "371afc28-4616-42fe-bb3f-fb6b1b86df3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e375704-69e8-46e4-a029-101fb73f36ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77e7ba2f-f75b-43ec-b6cc-223e9ecf3f82", "6c8bc739-08df-48d5-875b-0a50b573fcf3", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "345cd6b8-613d-4311-973b-5ea23b417ca1", "d4684890-998a-40ec-beae-8e8e53e12adb", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "345cd6b8-613d-4311-973b-5ea23b417ca1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77e7ba2f-f75b-43ec-b6cc-223e9ecf3f82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "371afc28-4616-42fe-bb3f-fb6b1b86df3e", "1105e8c2-569f-44bb-ae6c-7bccb49323dc", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e375704-69e8-46e4-a029-101fb73f36ff", "a9f05d71-fa23-4657-8551-3bed081a69dd", "Business", "BUSINESS" });
        }
    }
}
