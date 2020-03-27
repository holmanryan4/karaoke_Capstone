using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Migrations
{
    public partial class upatingeventmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115efca5-45db-4ba2-b0b7-0254fb6e91e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b235e423-f990-44ab-aaf0-5668621b7f01");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31d929ad-2310-41ca-9c5a-0655567790c5", "24889f4f-93a8-4f61-b6c7-6de44ad1d6dc", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b43d16-2b68-4213-a4a5-49d67163659a", "98bf444b-3d76-471c-ba68-9fb150aaeffd", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31d929ad-2310-41ca-9c5a-0655567790c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b43d16-2b68-4213-a4a5-49d67163659a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "115efca5-45db-4ba2-b0b7-0254fb6e91e5", "1a6689ce-0af5-4ba5-adcf-7fc95b793553", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b235e423-f990-44ab-aaf0-5668621b7f01", "dbae940a-9217-4552-8fff-baabe1b06c1b", "Business", "BUSINESS" });
        }
    }
}
