using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Deduccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeduccionID { get; set; }

        [ForeignKey("Empleado")]
        public int NumeroEmpleado { get; set; }
        [Required]
        public double INSS {  get; set; }
        [Required]
        public double IR {  get; set; }
        [Required, StringLength(100)]
        public string ConceptoOD {  get; set; }
        [Required]
        public double MontoOtrasDeducciones {  get; set; }


        public  Empleado? Empleado { get; set; }



    }
}
