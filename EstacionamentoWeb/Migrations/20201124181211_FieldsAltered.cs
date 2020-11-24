using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class FieldsAltered : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Veiculo_VeiculoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_VeiculoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Veiculo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_UsuarioId",
                table: "Veiculo",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_UsuarioId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Veiculo");

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_VeiculoId",
                table: "Usuario",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Veiculo_VeiculoId",
                table: "Usuario",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
