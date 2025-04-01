using MedicalApp.Domain.BaseEntity;


namespace MedicalApp.Domain.Entities.MedicoFolder
{
    public class Medico : Trabajador
    {
        public string NumeroColegiado { get; set; }
        public TipoMedico Tipo { get; set; }
        // Horario de consultas (uno a muchos)
        public List<HorarioConsulta> HorariosConsulta { get; set; } = new List<HorarioConsulta>();
        // Registros de sustituciones (uno a muchos)
        public List<Sustitucion> Sustituciones { get; set; } = new List<Sustitucion>();
    }

}
