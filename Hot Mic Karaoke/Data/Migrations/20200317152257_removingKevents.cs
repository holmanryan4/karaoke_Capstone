using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class removingKevents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Business_Kevents_KeventsId",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Kevents_KeventsId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_KeventsId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Business_KeventsId",
                table: "Business");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d7f514d-6b91-4d5c-9bab-1a7234d86334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfdcf841-a2e4-48be-8ed7-e8cbc0b69b5d");

            migrationBuilder.DropColumn(
                name: "KeventsId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "KeventsId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9107ec3-052c-4c55-aa07-73f796782a7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c65a0c5d-1784-48d8-ae7b-9ef24a10c1df");

            migrationBuilder.AddColumn<int>(
                name: "KeventsId",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KeventsId",
                table: "Business",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfdcf841-a2e4-48be-8ed7-e8cbc0b69b5d", "3d80dbda-99e5-44b7-95ce-150c77901e5a", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d7f514d-6b91-4d5c-9bab-1a7234d86334", "0e2a77da-aceb-4b56-9fa5-f2b63284b93f", "Business", "BUSINESS" });

            migrationBuilder.CreateIndex(
                name: "IX_Member_KeventsId",
                table: "Member",
                column: "KeventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_KeventsId",
                table: "Business",
                column: "KeventsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_Kevents_KeventsId",
                table: "Business",
                column: "KeventsId",
                principalTable: "Kevents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Kevents_KeventsId",
                table: "Member",
                column: "KeventsId",
                principalTable: "Kevents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
