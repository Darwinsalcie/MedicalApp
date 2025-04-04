using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Response.BaseResponseDTO
{
    public abstract class PersonaResponseDTO
    {
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        public string? Cedula { get; set; }
        [Required]
        public string? Telefono { get; set; }

        [Required]
        public string? Direccion { get; set; }

        [Required]
        public string? Poblacion { get; set; }
        [Required]
        public string? Provincia { get; set; }

        public string? CodigoPostal { get; set; }
        [Required]
        public string? NIF { get; set; }
    }
}
