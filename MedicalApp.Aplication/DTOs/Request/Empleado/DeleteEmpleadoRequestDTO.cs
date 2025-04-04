
using MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO;
using System.ComponentModel.DataAnnotations;

namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class DeleteEmpleadoRequestDTO : AuditDeleteRequestDTO
    {
        [Required(ErrorMessage = "El campo Id es requerido.")]
        public int Id { get; set; }
    }
}
