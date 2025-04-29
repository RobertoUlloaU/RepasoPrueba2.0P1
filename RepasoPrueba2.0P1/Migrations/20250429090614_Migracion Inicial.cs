using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepasoPrueba2._0P1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                
                name: "Carro",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Cilindraje = table.Column<double>(type: "float", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropietarioIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Placa);
                    table.ForeignKey(
                    name: "FK_Carro_Propietario_PropietarioIdentificacion",
                    column: x => x.PropietarioIdentificacion,
                    principalTable: "Propietario",
                    principalColumn: "Identificacion",
                    onDelete: ReferentialAction.Restrict);

                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
