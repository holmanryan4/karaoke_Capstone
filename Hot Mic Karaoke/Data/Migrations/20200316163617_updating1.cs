using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class updating1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18d53445-cdfb-4486-a30f-7da4fad27a63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5033594-67b2-415c-86fd-2bfebb6d0cb9");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kevents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventLocation = table.Column<string>(nullable: false),
                    DateAndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kevents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(nullable: false),
                    AdminFirstName = table.Column<string>(nullable: false),
                    AdminLastName = table.Column<string>(nullable: false),
                    BusinessPhoneNumber = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    KeventsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Business_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Business_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Business_Kevents_KeventsId",
                        column: x => x.KeventsId,
                        principalTable: "Kevents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    KeventsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Member_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Kevents_KeventsId",
                        column: x => x.KeventsId,
                        principalTable: "Kevents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfdcf841-a2e4-48be-8ed7-e8cbc0b69b5d", "3d80dbda-99e5-44b7-95ce-150c77901e5a", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d7f514d-6b91-4d5c-9bab-1a7234d86334", "0e2a77da-aceb-4b56-9fa5-f2b63284b93f", "Business", "BUSINESS" });

            migrationBuilder.CreateIndex(
                name: "IX_Business_AddressId",
                table: "Business",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_AppUserId",
                table: "Business",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_KeventsId",
                table: "Business",
                column: "KeventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_AddressId",
                table: "Member",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_AppUserId",
                table: "Member",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_KeventsId",
                table: "Member",
                column: "KeventsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Kevents");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d7f514d-6b91-4d5c-9bab-1a7234d86334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfdcf841-a2e4-48be-8ed7-e8cbc0b69b5d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5033594-67b2-415c-86fd-2bfebb6d0cb9", "c04edf67-0181-488f-8c4c-015540365ba4", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18d53445-cdfb-4486-a30f-7da4fad27a63", "6763cb72-4ca9-495d-85d0-18b4de2abdab", "Business", "BUSINESS" });
        }
    }
}
