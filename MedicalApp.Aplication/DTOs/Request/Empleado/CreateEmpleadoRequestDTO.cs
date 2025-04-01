using MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO;
using System.ComponentModel.DataAnnotations;

namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class CreateEmpleadoRequestDTO : AuditCreateRequestDTO
    {

        [Required]
        public RolEmpleado? Rol { get; set; }
    }
}
