using Microsoft.EntityFrameworkCore.Migrations;

namespace Hot_Mic_Karaoke.Migrations
{
    public partial class changingdatatypeonrating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9318dafa-c289-4bdd-a93d-6bf1ce1ce0fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea75ec2-5b61-404f-8c12-bb714ee094c8");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "SongList",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "371afc28-4616-42fe-bb3f-fb6b1b86df3e", "1105e8c2-569f-44bb-ae6c-7bccb49323dc", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e375704-69e8-46e4-a029-101fb73f36ff", "a9f05d71-fa23-4657-8551-3bed081a69dd", "Business", "BUSINESS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "371afc28-4616-42fe-bb3f-fb6b1b86df3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e375704-69e8-46e4-a029-101fb73f36ff");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "SongList",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dea75ec2-5b61-404f-8c12-bb714ee094c8", "9bd09bd2-c998-46ee-9c72-56f2bdcd0348", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9318dafa-c289-4bdd-a93d-6bf1ce1ce0fb", "b59417db-460b-4899-b68d-16708389aee2", "Business", "BUSINESS" });
        }
    }
}
