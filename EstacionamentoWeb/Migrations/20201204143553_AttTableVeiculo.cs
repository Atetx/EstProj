using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class AttTableVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Estacionados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    VeiculoId = table.Column<int>(type: "int", nullable: true),
                    EstacionamentoId = table.Column<int>(type: "int", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estacionados_Estacionamentos_EstacionamentoId",
                        column: x => x.EstacionamentoId,
                        principalTable: "Estacionamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estacionados_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estacionados_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estacionados_EstacionamentoId",
                table: "Estacionados",
                column: "EstacionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estacionados_UsuarioId",
                table: "Estacionados",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estacionados_VeiculoId",
                table: "Estacionados",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo");

            migrationBuilder.DropTable(
                name: "Estacionados");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Veiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
