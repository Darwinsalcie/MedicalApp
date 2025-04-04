

namespace MedicalApp.Domain.Entities
{
    public class HorarioConsulta
    {
        public int Id { get; set; }
        public DayOfWeek DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        // Clave foránea al médico
        //Implementar con una propiedad de navegación
        public int MedicoId { get; set; }
    }
}
