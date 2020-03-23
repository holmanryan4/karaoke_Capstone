using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Migrations
{
    public partial class inital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14cbda40-1085-40fc-9d84-f86a36f69341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb668e8e-8b56-475e-b500-a98f8d0f321a");

            migrationBuilder.CreateTable(
                name: "SongList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Artist = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c94e2f9-97ad-4a53-9472-0a8d5c5fdb83", "2bcdd04e-3b34-4361-af49-fc3076f34441", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "504c3ce0-e224-4f30-84bf-e295ef2f7968", "b98bd96b-73be-4103-9853-90dd5631e7f7", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SongList");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c94e2f9-97ad-4a53-9472-0a8d5c5fdb83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "504c3ce0-e224-4f30-84bf-e295ef2f7968");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb668e8e-8b56-475e-b500-a98f8d0f321a", "0a2f5d99-79ed-4738-a44a-3c8438105f83", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14cbda40-1085-40fc-9d84-f86a36f69341", "0cf72bb1-7fbb-44d6-8117-1a59c7c5d0f5", "Business", "BUSINESS" });
        }
    }
}
