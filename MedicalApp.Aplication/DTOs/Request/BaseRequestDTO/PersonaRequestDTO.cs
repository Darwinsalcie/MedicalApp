﻿
using System.ComponentModel.DataAnnotations;


namespace MedicalApp.Aplication.DTOs.Request.BaseEntity
{
    public abstract class PersonaRequestDTO
    {
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }

        [Required]
        public string? Direccion { get; set; }
        [Required]
        public string? Telefono { get; set; }
        [Required]
        public string? Poblacion { get; set; }
        [Required]
        public string? Provincia { get; set; }

        public string? CodigoPostal { get; set; }
        [Required]
        public string? NIF { get; set; }
        [Required]
        public string? Cedula { get; set; }
    }
}
