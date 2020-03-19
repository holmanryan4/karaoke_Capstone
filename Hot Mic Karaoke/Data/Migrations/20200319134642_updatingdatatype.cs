using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class updatingdatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a71ae1c-d1cd-4b0b-8ef1-278a25cb49cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63baa3d1-da3a-4933-b83b-9f0670587a74");

            migrationBuilder.AlterColumn<string>(
                name: "KaraokeNight",
                table: "Business",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce776317-bdbc-4955-89bb-261998e24670", "d9fdef4f-5796-432f-8828-251224232e70", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f249358-5f46-4275-835f-9d000c6887f7", "58523517-7abf-4079-8f47-c3b7cab6afe8", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f249358-5f46-4275-835f-9d000c6887f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce776317-bdbc-4955-89bb-261998e24670");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KaraokeNight",
                table: "Business",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63baa3d1-da3a-4933-b83b-9f0670587a74", "faf4fbb1-9923-436d-af4e-e1291f2d86cf", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a71ae1c-d1cd-4b0b-8ef1-278a25cb49cc", "f4a77999-8c1a-4abf-bb42-858c44d96af0", "Business", "BUSINESS" });
        }
    }
}
