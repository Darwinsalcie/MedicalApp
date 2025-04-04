
using MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO;
using System.ComponentModel.DataAnnotations;


namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class UpdateEmpleadoRequestDTO : AuditUpdateRequestDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

    }
}
