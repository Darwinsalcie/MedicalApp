using MedicalApp.Aplication.DTOs.Request.BaseEntity;

namespace MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO
{
    public abstract class AuditUpdateRequestDTO : TrabajadorRequestDTO
    {
        public int? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
