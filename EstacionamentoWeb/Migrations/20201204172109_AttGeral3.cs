using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class AttGeral3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Estacionamentos_EstacionamentoId",
                table: "Estacionados");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Veiculo_VeiculoId",
                table: "Estacionados");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Estacionados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Estacionados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstacionamentoId",
                table: "Estacionados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Estacionamentos_EstacionamentoId",
                table: "Estacionados",
                column: "EstacionamentoId",
                principalTable: "Estacionamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Veiculo_VeiculoId",
                table: "Estacionados",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Estacionamentos_EstacionamentoId",
                table: "Estacionados");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Veiculo_VeiculoId",
                table: "Estacionados");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Estacionados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Estacionados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EstacionamentoId",
                table: "Estacionados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Estacionamentos_EstacionamentoId",
                table: "Estacionados",
                column: "EstacionamentoId",
                principalTable: "Estacionamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Veiculo_VeiculoId",
                table: "Estacionados",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
