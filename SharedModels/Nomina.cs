using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Nomina
    {
        

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NominaID { get; set; }

        [ForeignKey("Empleado")]
        public int NumeroEmpleado { get; set; }
        [Required]

        public double TotalIngresos {  get; set; }
        [Required]
        public double TotalDeducciones {  get; set; }
        [Required]
        public double SalarioNeto {  get; set; }

        public Empleado? Empleado { get; set; }
    }
}
