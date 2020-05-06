using Microsoft.EntityFrameworkCore.Migrations;

namespace PixForce.Migrations
{
    public partial class Estoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCliente = table.Column<int>(nullable: false),
                    NomeCliente = table.Column<string>(nullable: true),
                    QtdEstoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Estoque",
                columns: new[] { "CodigoCliente", "NomeCliente", "QtdEstoque" },
                values: new object[] {
                    0079,
                    "CPFL ENERGIA",
                    99
                });;

            migrationBuilder.InsertData(
                table: "Estoque",
                columns: new[] { "CodigoCliente", "NomeCliente", "QtdEstoque" },
                values: new object[] {
                    0965,
                    "PIX FORCE",
                    889
                });;

            migrationBuilder.InsertData(
                table: "Estoque",
                columns: new[] { "CodigoCliente", "NomeCliente", "QtdEstoque" },
                values: new object[] {
                    0046,
                    "SUVINIL",
                    1805
                }); ;
            migrationBuilder.InsertData(
                table: "Estoque",
                columns: new[] { "CodigoCliente", "NomeCliente", "QtdEstoque" },
                values: new object[] {
                    5687,
                    "PANDURATA ALIMENTOS LTDA.",
                    1805
                }); ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoque");
        }
    }
}
