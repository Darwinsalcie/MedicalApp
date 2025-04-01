using MedicalApp.Domain.Entities.VacacionFolder;
namespace MedicalApp.Domain.BaseEntity
{
    public abstract class Trabajador : AuditEntity
    {
        // Relación uno a muchos con Vacacion
        public List<Vacacion> Vacaciones { get; set; } = new List<Vacacion>();
    }
}
