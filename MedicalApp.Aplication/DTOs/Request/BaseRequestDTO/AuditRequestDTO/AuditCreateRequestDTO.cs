using MedicalApp.Aplication.DTOs.Request.BaseEntity;

namespace MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO
{
    public abstract class AuditCreateRequestDTO : TrabajadorRequestDTO
    {
        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
