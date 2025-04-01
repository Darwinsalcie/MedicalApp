using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Domain.BaseEntity
{
    public abstract class AuditEntity : Persona
    {
        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
        public int? ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
