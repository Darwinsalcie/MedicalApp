using MedicalApp.Domain.BaseEntity;


namespace MedicalApp.Domain.Entities
{
    public class Paciente : Persona
    {
        // Relación: cada paciente tiene asignado un médico
        public int MedicoAsignadoId { get; set; }
        public Medico MedicoAsignado { get; set; }
    }
}
