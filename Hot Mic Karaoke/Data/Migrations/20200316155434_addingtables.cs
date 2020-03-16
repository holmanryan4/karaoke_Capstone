using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class addingtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70fc02a8-080c-4770-8f26-9a6f37f0986a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5033594-67b2-415c-86fd-2bfebb6d0cb9", "c04edf67-0181-488f-8c4c-015540365ba4", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18d53445-cdfb-4486-a30f-7da4fad27a63", "6763cb72-4ca9-495d-85d0-18b4de2abdab", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18d53445-cdfb-4486-a30f-7da4fad27a63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5033594-67b2-415c-86fd-2bfebb6d0cb9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70fc02a8-080c-4770-8f26-9a6f37f0986a", "514c6c46-e953-4ca1-8a29-2a0c98435294", "Admin", "ADMIN" });
        }
    }
}
