using System;
using Microsoft.EntityFrameworkCore.Migrations;
using PixForce.Services;

namespace PixForce.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
            byte[] passwordHash, passwordSalt;
            UserService.CreatePasswordHash("123456", out passwordHash, out passwordSalt);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FirstName", "LastName", "Username", "PasswordHash", "PasswordSalt" },
                values: new object[] {
                    "Matheus",
                    "Gomes",
                    "magomes",
                    passwordHash,
                    passwordSalt
                }); ;

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FirstName", "LastName", "Username", "PasswordHash", "PasswordSalt" },
                values: new object[] {
                    "Elyse",
                    "Nunes",
                    "ecnunes",
                    passwordHash,
                    passwordSalt
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FirstName", "LastName", "Username", "PasswordHash", "PasswordSalt" },
                values: new object[] {
                    "Pix",
                    "Force",
                    "pforce",
                    passwordHash,
                    passwordSalt
                });
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "FirstName", "LastName", "Username", "PasswordHash", "PasswordSalt" },
                values: new object[] {
                    "Admin",
                    "System",
                    "admin",
                    passwordHash,
                    passwordSalt
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }

    }
}
