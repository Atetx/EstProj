using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class AddUsuarioTableEstacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Estacionamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamentos_UsuarioId",
                table: "Estacionamentos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_Usuario_UsuarioId",
                table: "Estacionamentos",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_Usuario_UsuarioId",
                table: "Estacionamentos");

            migrationBuilder.DropIndex(
                name: "IX_Estacionamentos_UsuarioId",
                table: "Estacionamentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Estacionamentos");
        }
    }
}
