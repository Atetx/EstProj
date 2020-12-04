using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class AddTableEstacionar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_Usuario_UsuarioId",
                table: "Estacionamentos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Estacionamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_Usuario_UsuarioId",
                table: "Estacionamentos",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_Usuario_UsuarioId",
                table: "Estacionamentos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Estacionamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_Usuario_UsuarioId",
                table: "Estacionamentos",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
