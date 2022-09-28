using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Cero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 30, nullable: false),
                    NumeroTelefono = table.Column<string>(nullable: true),
                    CorreoElectronico = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    IdUsuario = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true),
                    TarjetaProfesional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Color = table.Column<string>(maxLength: 20, nullable: false),
                    Raza = table.Column<string>(maxLength: 30, nullable: false),
                    Genero = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    VeterinarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeterinarioId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    MascotaId = table.Column<int>(nullable: true),
                    FechaVisita = table.Column<DateTime>(nullable: false),
                    Temperatura = table.Column<float>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(nullable: false),
                    EstadoAnimo = table.Column<int>(nullable: false),
                    Recomendaciones = table.Column<string>(nullable: true),
                    FormulaMedicamentos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitas_Personas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitas_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitas_Personas_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_ClienteId",
                table: "Mascotas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_VeterinarioId",
                table: "Mascotas",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_ClienteId",
                table: "Visitas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_MascotaId",
                table: "Visitas",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_VeterinarioId",
                table: "Visitas",
                column: "VeterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
