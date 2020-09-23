using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearning.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nishant", "Pathak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Gaurang", "Majethiya" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { 1, new byte[] { 8, 60, 33, 144, 30, 0, 224, 85, 137, 76, 94, 15, 48, 100, 173, 137, 98, 44, 246, 17, 164, 134, 147, 65, 105, 169, 111, 24, 143, 92, 132, 215, 62, 128, 242, 92, 127, 62, 180, 37, 40, 18, 196, 121, 48, 66, 187, 201, 5, 18, 63, 220, 98, 239, 94, 92, 255, 26, 152, 133, 134, 107, 41, 191 }, new byte[] { 129, 156, 246, 179, 159, 80, 207, 25, 43, 168, 54, 187, 255, 162, 73, 160, 80, 113, 179, 145, 225, 249, 124, 105, 12, 132, 122, 14, 240, 157, 132, 38, 10, 116, 170, 1, 159, 233, 82, 152, 174, 10, 77, 247, 42, 131, 66, 51, 146, 35, 176, 206, 248, 82, 93, 222, 120, 152, 2, 105, 133, 145, 235, 97, 1, 83, 5, 160, 56, 117, 58, 77, 124, 10, 157, 142, 130, 21, 116, 83, 61, 147, 79, 55, 113, 163, 223, 173, 186, 113, 223, 41, 137, 137, 244, 62, 71, 139, 99, 153, 35, 108, 170, 143, 11, 107, 45, 163, 116, 165, 66, 132, 237, 198, 236, 197, 52, 182, 13, 183, 251, 120, 182, 170, 57, 66, 154, 53 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
