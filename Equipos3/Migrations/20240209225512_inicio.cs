using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Equipos3.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    CodigoEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Propietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CTE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subestacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Elemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDeEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PL2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rdf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.CodigoEvento);
                });

            migrationBuilder.InsertData(
                table: "Equipos",
                columns: new[] { "CodigoEvento", "CTE", "Elemento", "Fecha", "NombreEquipo", "Opciones", "PL1", "PL2", "Propietario", "Rdf", "SOE", "Subestacion", "TipoDeEquipo" },
                values: new object[,]
                {
                    { 2, "CTE Occidente", "BL Amazonas 230 rio 2", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BL Amazonas 230 KV rio 1 SEL321", "Activo", "Sí", "Sí", "5 Five", "Activo", "NO", "Amazonas 230 KV", "Relé de presentación" },
                    { 3, "CTE Oriente", "BL Guajira 230 Soacha 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BL Guajirá 230 KV Sogamoso 1 SEL321", "Activo", "Sí", "No", "Emtelco", "Activo", "Sí", "Guajira 230 KV", "Relé de presentación" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
