using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto
{
    public class NominaUpdateDto
    {
        [Required]
        public int NominaID { get; set; }

        [Required]
        public int NumeroEmpleado { get; set; }

        [Required]
        public double SalarioNeto { get; set; }

        [Required]
        public DateOnly FechaNomina { get; set; }
    }
}
