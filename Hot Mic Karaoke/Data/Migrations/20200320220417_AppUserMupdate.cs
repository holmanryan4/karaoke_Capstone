using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class AppUserMupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e1e7b4b-a622-4cc9-b1e9-65f9fb7cf543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3017b7b5-5db4-49b5-b6d6-8780560117f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce3342e4-993f-49b7-af76-4d0c93d061ea", "d0c1c411-6f38-461f-bcac-6dbaa6ff22ca", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b6326e5-bbf1-453e-8a57-472ca28904cb", "ebffcec4-35fa-451d-89e5-97a7a4b81def", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6326e5-bbf1-453e-8a57-472ca28904cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce3342e4-993f-49b7-af76-4d0c93d061ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e1e7b4b-a622-4cc9-b1e9-65f9fb7cf543", "efca72a6-4668-4f7a-b0bf-9e5e08f2d70f", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3017b7b5-5db4-49b5-b6d6-8780560117f1", "d680d06e-9dc7-4980-b7a1-a2d733833d16", "Business", "BUSINESS" });
        }
    }
}
