using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class addingkaraokeenight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9107ec3-052c-4c55-aa07-73f796782a7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c65a0c5d-1784-48d8-ae7b-9ef24a10c1df");

            migrationBuilder.AddColumn<DateTime>(
                name: "KaraokeNight",
                table: "Business",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf32f188-b2a9-418b-9622-97b3c0a2ea9b", "039b009a-d8e8-4b05-8e03-4ba3762f3966", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70dae243-66b9-4134-9d64-efd780e65d0b", "332ce03d-299e-4571-a91d-77ad86c577c8", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70dae243-66b9-4134-9d64-efd780e65d0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf32f188-b2a9-418b-9622-97b3c0a2ea9b");

            migrationBuilder.DropColumn(
                name: "KaraokeNight",
                table: "Business");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9107ec3-052c-4c55-aa07-73f796782a7c", "f6585b15-30fb-4682-a067-37b7cb369e94", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c65a0c5d-1784-48d8-ae7b-9ef24a10c1df", "62b75005-627b-40fb-a10f-e3b142cd33e2", "Business", "BUSINESS" });
        }
    }
}
