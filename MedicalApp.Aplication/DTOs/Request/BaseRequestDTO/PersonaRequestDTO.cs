
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Request.BaseEntity
{
    public abstract class PersonaRequestDTO
    {
        [Required]
        public string? Nombre { get; set; }
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
