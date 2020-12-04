using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class AttGeral5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Estacionados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Estacionados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionados_Usuario_UsuarioId",
                table: "Estacionados",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
