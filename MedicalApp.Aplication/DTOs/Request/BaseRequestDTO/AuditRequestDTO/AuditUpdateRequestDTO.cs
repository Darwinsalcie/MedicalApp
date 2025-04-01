using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO
{
    public abstract class AuditUpdateRequestDTO : TrabajadorRequestDTO
    {
        public int? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
