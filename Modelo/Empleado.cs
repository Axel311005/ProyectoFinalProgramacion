using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado: I_Ingresos,IDeducciones
    {

        public int NumeroEmpleados {  get; set; }
        public string NumeroCedula { get; set; }
        public int NumeroInss { get; set; }
        public string NumeroRuc { get; set; } //14 caracteres - dos o una letra
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime FechaFinalizacionContrato { get; set; }
        public double SalarioBase { get; set; }
        public string EstadoDelEmpleado { get; set; }
        public double Antiguedad { get ; set ; }
        public double RiesgoLaboral { get ; set ; }
        public double Nocturnidad { get; set ; }
        public double OtrosIngresos { get ; set ; }
        public int HorasExtras { get; set ; }
        public double INSS { get; set ; }
        public double IR { get ; set ; }
        public double OtrasDeducciones { get ; set ; }
    }
}
