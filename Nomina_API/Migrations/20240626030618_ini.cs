using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nomina_API.Migrations
{
    /// <inheritdoc />
    public partial class ini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    NumeroEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroINSS = table.Column<int>(type: "int", nullable: false),
                    NumeroRUC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    FechaContratacion = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaCierreContrato = table.Column<DateOnly>(type: "date", nullable: false),
                    EstadoEmpleado = table.Column<bool>(type: "bit", nullable: false),
                    YearsTrabajados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.NumeroEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deducciones",
                columns: table => new
                {
                    DeduccionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleado = table.Column<int>(type: "int", nullable: false),
                    INSS = table.Column<double>(type: "float", nullable: false),
                    IR = table.Column<double>(type: "float", nullable: false),
                    ConceptoOD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MontoOtrasDeducciones = table.Column<double>(type: "float", nullable: false),
                    TotalDeducciones = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deducciones", x => x.DeduccionID);
                    table.ForeignKey(
                        name: "FK_Deducciones_Empleados_NumeroEmpleado",
                        column: x => x.NumeroEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "NumeroEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingresos",
                columns: table => new
                {
                    IngresoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleado = table.Column<int>(type: "int", nullable: false),
                    SalarioOrdinario = table.Column<double>(type: "float", nullable: false),
                    Antiguedad = table.Column<double>(type: "float", nullable: false),
                    RiesgoLaboral = table.Column<double>(type: "float", nullable: false),
                    Nocturnidad = table.Column<double>(type: "float", nullable: false),
                    HorasExtras = table.Column<double>(type: "float", nullable: false),
                    ConceptoOtrosIngresos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OtrosIngresos = table.Column<double>(type: "float", nullable: false),
                    TotalIngresos = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresos", x => x.IngresoID);
                    table.ForeignKey(
                        name: "FK_Ingresos_Empleados_NumeroEmpleado",
                        column: x => x.NumeroEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "NumeroEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nominas",
                columns: table => new
                {
                    NominaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleado = table.Column<int>(type: "int", nullable: false),
                    SalarioNeto = table.Column<double>(type: "float", nullable: false),
                    FechaNomina = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominas", x => x.NominaID);
                    table.ForeignKey(
                        name: "FK_Nominas_Empleados_NumeroEmpleado",
                        column: x => x.NumeroEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "NumeroEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deducciones_NumeroEmpleado",
                table: "Deducciones",
                column: "NumeroEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_NumeroEmpleado",
                table: "Ingresos",
                column: "NumeroEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_NumeroEmpleado",
                table: "Nominas",
                column: "NumeroEmpleado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deducciones");

            migrationBuilder.DropTable(
                name: "Ingresos");

            migrationBuilder.DropTable(
                name: "Nominas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
