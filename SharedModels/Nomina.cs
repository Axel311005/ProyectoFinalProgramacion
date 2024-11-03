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
        public double SalarioNeto {  get; set; }
        [Required]
        public DateOnly FechaNomina { get; set; }

        public Empleado? Empleado { get; set; }
    }
}
