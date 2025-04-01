

namespace MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO
{
    public abstract class AuditDeleteRequestDTO : TrabajadorRequestDTO
    {
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
