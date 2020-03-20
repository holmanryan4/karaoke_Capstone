using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class addingviewmodelfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "80acf01e-3d8d-404a-b4c2-1f9bdb90b936", "cae6dd90-3e39-4b17-8e54-7a418d074b49", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3040efe-58d6-4da0-80d3-d55fa38f23a8", "a99ff30c-dd59-4d54-b98c-42466857c9eb", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80acf01e-3d8d-404a-b4c2-1f9bdb90b936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3040efe-58d6-4da0-80d3-d55fa38f23a8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "547a573b-ee25-490e-88f2-b4e1235be807", "d6a2002e-c32f-4745-8a47-bc275bcce90b", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1e46d9e-ec41-4af7-8963-48983e7a0d4f", "e14ba1f2-f9b2-4746-b1dd-dd5d10375fb0", "Business", "BUSINESS" });
        }
    }
}
