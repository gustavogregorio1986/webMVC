using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Data.Migrations
{
    public partial class CriarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Passageiro",
                columns: table => new
                {
                    IdPassageiro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePssageiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmaqilPassageiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Passageiro", x => x.IdPassageiro);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aeroporto",
                columns: table => new
                {
                    IdAero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Passageiro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aeroporto", x => x.IdAero);
                    table.ForeignKey(
                        name: "FK_tb_Aeroporto_tb_Passageiro_Id_Passageiro",
                        column: x => x.Id_Passageiro,
                        principalTable: "tb_Passageiro",
                        principalColumn: "IdPassageiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Passageiro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Passageiro_Id_Passageiro",
                        column: x => x.Id_Passageiro,
                        principalTable: "tb_Passageiro",
                        principalColumn: "IdPassageiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aviao",
                columns: table => new
                {
                    IdAviao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Compania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeAviao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poltrona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Aeroporto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aviao", x => x.IdAviao);
                    table.ForeignKey(
                        name: "FK_tb_Aviao_tb_Aeroporto_Id_Aeroporto",
                        column: x => x.Id_Aeroporto,
                        principalTable: "tb_Aeroporto",
                        principalColumn: "IdAero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Destino",
                columns: table => new
                {
                    IdDstino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadwDestino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmbarque = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Aviao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Destino", x => x.IdDstino);
                    table.ForeignKey(
                        name: "FK_tb_Destino_tb_Aviao_Id_Aviao",
                        column: x => x.Id_Aviao,
                        principalTable: "tb_Aviao",
                        principalColumn: "IdAviao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Orgem",
                columns: table => new
                {
                    IdOrigem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadwOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmbarque = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Aviao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Orgem", x => x.IdOrigem);
                    table.ForeignKey(
                        name: "FK_tb_Orgem_tb_Aviao_Id_Aviao",
                        column: x => x.Id_Aviao,
                        principalTable: "tb_Aviao",
                        principalColumn: "IdAviao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Aeroporto_Id_Passageiro",
                table: "tb_Aeroporto",
                column: "Id_Passageiro");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Aviao_Id_Aeroporto",
                table: "tb_Aviao",
                column: "Id_Aeroporto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Destino_Id_Aviao",
                table: "tb_Destino",
                column: "Id_Aviao");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Passageiro",
                table: "tb_Endereco",
                column: "Id_Passageiro");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Orgem_Id_Aviao",
                table: "tb_Orgem",
                column: "Id_Aviao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Destino");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Orgem");

            migrationBuilder.DropTable(
                name: "tb_Aviao");

            migrationBuilder.DropTable(
                name: "tb_Aeroporto");

            migrationBuilder.DropTable(
                name: "tb_Passageiro");
        }
    }
}
