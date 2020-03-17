using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class workhours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10922b9e-e294-49a6-84d6-790036c2d5e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27bf49df-0fb7-4793-8dc7-215df822e66c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63baa3d1-da3a-4933-b83b-9f0670587a74", "faf4fbb1-9923-436d-af4e-e1291f2d86cf", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a71ae1c-d1cd-4b0b-8ef1-278a25cb49cc", "f4a77999-8c1a-4abf-bb42-858c44d96af0", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a71ae1c-d1cd-4b0b-8ef1-278a25cb49cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63baa3d1-da3a-4933-b83b-9f0670587a74");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27bf49df-0fb7-4793-8dc7-215df822e66c", "0c1fe4d6-c336-462d-900a-a5e2537827fa", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10922b9e-e294-49a6-84d6-790036c2d5e2", "e84ccfc7-44ee-4c05-b12a-50142a0f5fa3", "Business", "BUSINESS" });
        }
    }
}
