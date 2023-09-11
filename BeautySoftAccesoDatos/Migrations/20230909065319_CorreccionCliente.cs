using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrlImagen",
                table: "Cliente",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Cliente",
                newName: "Nombre");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmarContraseña",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ConfirmarContraseña",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Cliente",
                newName: "UrlImagen");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Cliente",
                newName: "Celular");
        }
    }
}
