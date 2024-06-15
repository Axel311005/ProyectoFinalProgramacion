using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto
{
    public class DeduccionUpdateDto
    {
        [Required]
        public int DeduccionID { get; set; }
        [Required]
        public int NumeroEmpleado { get; set; }
        [Required]
        public double INSS { get; set; }
        [Required]
        public double IR { get; set; }
        [Required, StringLength(100)]
        public string ConceptoOD { get; set; }
        [Required]
        public double MontoOtrasDeducciones { get; set; }
    }
}
