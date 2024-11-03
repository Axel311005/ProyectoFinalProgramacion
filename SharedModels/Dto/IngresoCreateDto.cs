using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto
{
    public class IngresoCreateDto
    {
       

        [Required]
        public int NumeroEmpleado { get; set; }

        [Required]
        public double SalarioOrdinario { get; set; }

        [Required]
        public double Antiguedad { get; set; }
        [Required]
        public double RiesgoLaboral { get; set; }
        [Required]
        public double Nocturnidad { get; set; }
        [Required]
        public double HorasExtras { get; set; }

        [Required, StringLength(100)]
        public string ConceptoOtrosIngresos { get; set; }
        [Required]
        public double OtrosIngresos { get; set; }
        [Required]
        public double TotalIngresos { get; set; }

    }
}
