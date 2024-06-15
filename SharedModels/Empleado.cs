using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroEmpleado { get; set; }

        [Required, StringLength(50)]
        public string NumeroCedula { get; set; }
        [Required]
        public int NumeroINSS { get; set; }
        [Required,StringLength(50)]
        public string NumeroRUC { get; set; }
        [Required, StringLength(50)]
        public string PrimerNombre { get; set; }
        [Required, StringLength(50)]
        public string SegundoNombre { get; set; }
        [Required, StringLength(50)]
        public string PrimerApellido { get; set; }
        [Required, StringLength(50)]
        public string SegundoApellido { get; set; }
        [Required]
        public DateOnly FechaNacimiento { get; set; }
        [Required, StringLength(50)]
        public string Sexo { get; set; }
        [Required, StringLength(50)]
        public string EstadoCivil { get; set; }
        [Required, StringLength(100)]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public int Celular { get; set; }
        [Required]

        public DateOnly FechaContratacion { get; set; }
        [Required]
        public DateOnly FechaCierreContrato { get; set; }
        [Required, StringLength(50)]
        public bool EstadoEmpleado { get; set; }
        [Required]
        public int YearsTrabajados {  get; set; }   
        

        public  ICollection<Deduccion>? Deducciones { get; set; }
        public  ICollection<Ingreso>? Ingresos { get; set; }
        public  ICollection<Nomina>? Nominas { get; set; }
    }
}
