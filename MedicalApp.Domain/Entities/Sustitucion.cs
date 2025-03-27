

namespace MedicalApp.Domain.Entities
{
    public class Sustitucion
    {
        public int Id { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        // Clave foránea al médico
        public int MedicoId { get; set; }
    }
}
