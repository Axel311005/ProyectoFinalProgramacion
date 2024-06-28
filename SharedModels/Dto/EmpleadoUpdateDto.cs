﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedModels.Dto
{
    public class EmpleadoUpdateDto
    {
        [Required]
        public int NumeroEmpleado { get; set; }

        [Required, StringLength(50)]
        public string NumeroCedula { get; set; }
        [Required]
        public int NumeroINSS { get; set; }
        [Required, StringLength(50)]
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
        [Required]
        public bool EstadoEmpleado { get; set; }
        [Required]
        public int YearsTrabajados { get; set; }

    }
}
