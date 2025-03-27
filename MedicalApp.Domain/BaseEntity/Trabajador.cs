using MedicalApp.Domain.Entities;

namespace MedicalApp.Domain.BaseEntity
{
    public abstract class Trabajador : Persona
    {
        // Relación uno a muchos con Vacacion
        public List<Vacacion> Vacaciones { get; set; } = new List<Vacacion>();
    }
}
