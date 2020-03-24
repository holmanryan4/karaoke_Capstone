using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Migrations
{
    public partial class addingsong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Member_MemberId",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Member_MemberMessagesId",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_AspNetUsers_UserID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MemberId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MemberMessagesId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_UserID",
                table: "Member");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c94e2f9-97ad-4a53-9472-0a8d5c5fdb83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "504c3ce0-e224-4f30-84bf-e295ef2f7968");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MemberMessagesId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "When",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "text",
                table: "Member");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "SongList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SongList",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SongListId",
                table: "Member",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    text = table.Column<string>(nullable: false),
                    When = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    MemberMessagesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_SongList_MemberMessagesId",
                        column: x => x.MemberMessagesId,
                        principalTable: "SongList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74e10377-5119-493e-b286-6756c5d062c7", "0ce4c75e-e09e-4f5d-814d-6115b8e35800", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a850dcf-0af8-4632-9cb5-3874878371cd", "637fe03f-d7cd-42cb-8176-b4e9ba29549b", "Business", "BUSINESS" });

            migrationBuilder.CreateIndex(
                name: "IX_SongList_MemberId",
                table: "SongList",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_SongListId",
                table: "Member",
                column: "SongListId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MemberMessagesId",
                table: "Messages",
                column: "MemberMessagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserID",
                table: "Messages",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_SongList_SongListId",
                table: "Member",
                column: "SongListId",
                principalTable: "SongList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SongList_Member_MemberId",
                table: "SongList",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_SongList_SongListId",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_SongList_Member_MemberId",
                table: "SongList");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_SongList_MemberId",
                table: "SongList");

            migrationBuilder.DropIndex(
                name: "IX_Member_SongListId",
                table: "Member");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a850dcf-0af8-4632-9cb5-3874878371cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74e10377-5119-493e-b286-6756c5d062c7");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "SongList");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SongList");

            migrationBuilder.DropColumn(
                name: "SongListId",
                table: "Member");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Member",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberMessagesId",
                table: "Member",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Member",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "When",
                table: "Member",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "text",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c94e2f9-97ad-4a53-9472-0a8d5c5fdb83", "2bcdd04e-3b34-4361-af49-fc3076f34441", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "504c3ce0-e224-4f30-84bf-e295ef2f7968", "b98bd96b-73be-4103-9853-90dd5631e7f7", "Business", "BUSINESS" });

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberId",
                table: "Member",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberMessagesId",
                table: "Member",
                column: "MemberMessagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_UserID",
                table: "Member",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Member_MemberId",
                table: "Member",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Member_MemberMessagesId",
                table: "Member",
                column: "MemberMessagesId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_AspNetUsers_UserID",
                table: "Member",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
