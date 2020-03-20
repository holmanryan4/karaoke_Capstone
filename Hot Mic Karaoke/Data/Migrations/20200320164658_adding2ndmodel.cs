using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class adding2ndmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6d2997-c20c-4859-b13d-3535966b574c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdaf2f2e-0d6f-496b-9794-4f7fa4107e3b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "547a573b-ee25-490e-88f2-b4e1235be807", "d6a2002e-c32f-4745-8a47-bc275bcce90b", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1e46d9e-ec41-4af7-8963-48983e7a0d4f", "e14ba1f2-f9b2-4746-b1dd-dd5d10375fb0", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "547a573b-ee25-490e-88f2-b4e1235be807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1e46d9e-ec41-4af7-8963-48983e7a0d4f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb6d2997-c20c-4859-b13d-3535966b574c", "3fdd6f81-3aa7-4731-becd-bc921940bf4e", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cdaf2f2e-0d6f-496b-9794-4f7fa4107e3b", "ce9a1d82-17e6-411a-ab06-0cf25b6c8c58", "Business", "BUSINESS" });
        }
    }
}
