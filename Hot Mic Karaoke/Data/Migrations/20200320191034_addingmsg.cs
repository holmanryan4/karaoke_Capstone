using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Data.Migrations
{
    public partial class addingmsg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80acf01e-3d8d-404a-b4c2-1f9bdb90b936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3040efe-58d6-4da0-80d3-d55fa38f23a8");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Messages",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MemberMessagesId",
                table: "Messages",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e1e7b4b-a622-4cc9-b1e9-65f9fb7cf543", "efca72a6-4668-4f7a-b0bf-9e5e08f2d70f", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3017b7b5-5db4-49b5-b6d6-8780560117f1", "d680d06e-9dc7-4980-b7a1-a2d733833d16", "Business", "BUSINESS" });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MemberId",
                table: "Messages",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MemberMessagesId",
                table: "Messages",
                column: "MemberMessagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Member_MemberId",
                table: "Messages",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_MemberMessagesId",
                table: "Messages",
                column: "MemberMessagesId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Member_MemberId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_MemberMessagesId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_MemberId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_MemberMessagesId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e1e7b4b-a622-4cc9-b1e9-65f9fb7cf543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3017b7b5-5db4-49b5-b6d6-8780560117f1");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MemberMessagesId",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80acf01e-3d8d-404a-b4c2-1f9bdb90b936", "cae6dd90-3e39-4b17-8e54-7a418d074b49", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3040efe-58d6-4da0-80d3-d55fa38f23a8", "a99ff30c-dd59-4d54-b98c-42466857c9eb", "Business", "BUSINESS" });
        }
    }
}
