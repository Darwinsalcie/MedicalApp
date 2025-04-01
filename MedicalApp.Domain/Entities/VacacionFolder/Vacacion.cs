namespace MedicalApp.Domain.Entities.VacacionFolder
{
    public class Vacacion
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstadoVacacion Estado { get; set; }
        // Clave foránea al trabajador (Médico o Empleado)
        public int TrabajadorId { get; set; }
    }


}
