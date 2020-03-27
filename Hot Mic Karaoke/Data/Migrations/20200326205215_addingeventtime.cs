using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Migrations
{
    public partial class addingeventtime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0898f503-fe40-46fd-a652-a2acb90cb310");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e877fa-8e80-4fcc-b1b5-01225c6849d6");

            migrationBuilder.AlterColumn<string>(
                name: "EventInfo",
                table: "KaraokeEvent",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAndTime",
                table: "KaraokeEvent",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "115efca5-45db-4ba2-b0b7-0254fb6e91e5", "1a6689ce-0af5-4ba5-adcf-7fc95b793553", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b235e423-f990-44ab-aaf0-5668621b7f01", "dbae940a-9217-4552-8fff-baabe1b06c1b", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115efca5-45db-4ba2-b0b7-0254fb6e91e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b235e423-f990-44ab-aaf0-5668621b7f01");

            migrationBuilder.DropColumn(
                name: "DateAndTime",
                table: "KaraokeEvent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EventInfo",
                table: "KaraokeEvent",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0898f503-fe40-46fd-a652-a2acb90cb310", "f81d29f9-37c4-4c9b-9310-ee46df6938fb", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2e877fa-8e80-4fcc-b1b5-01225c6849d6", "ca869c58-e6de-4680-a765-2f534917d31e", "Business", "BUSINESS" });
        }
    }
}
