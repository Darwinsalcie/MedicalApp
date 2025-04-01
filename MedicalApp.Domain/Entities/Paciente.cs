using MedicalApp.Domain.BaseEntity;
using MedicalApp.Domain.Entities.MedicoFolder;

namespace MedicalApp.Domain.Entities
{
    public class Paciente : Persona
    {
        // Relación: cada paciente tiene asignado un médico
        public int MedicoAsignadoId { get; set; }
        public Medico MedicoAsignado { get; set; }
    }
}
