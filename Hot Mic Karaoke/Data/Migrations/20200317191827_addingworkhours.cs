using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class addingworkhours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70dae243-66b9-4134-9d64-efd780e65d0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf32f188-b2a9-418b-9622-97b3c0a2ea9b");

            migrationBuilder.AddColumn<string>(
                name: "WorkHours",
                table: "Business",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27bf49df-0fb7-4793-8dc7-215df822e66c", "0c1fe4d6-c336-462d-900a-a5e2537827fa", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10922b9e-e294-49a6-84d6-790036c2d5e2", "e84ccfc7-44ee-4c05-b12a-50142a0f5fa3", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10922b9e-e294-49a6-84d6-790036c2d5e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27bf49df-0fb7-4793-8dc7-215df822e66c");

            migrationBuilder.DropColumn(
                name: "WorkHours",
                table: "Business");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf32f188-b2a9-418b-9622-97b3c0a2ea9b", "039b009a-d8e8-4b05-8e03-4ba3762f3966", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70dae243-66b9-4134-9d64-efd780e65d0b", "332ce03d-299e-4571-a91d-77ad86c577c8", "Business", "BUSINESS" });
        }
    }
}
