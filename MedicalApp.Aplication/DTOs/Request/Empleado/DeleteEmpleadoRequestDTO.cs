
using MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO;

namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class DeleteEmpleadoRequestDTO : AuditDeleteRequestDTO
    {
        public int Id { get; set; }
    }
}
