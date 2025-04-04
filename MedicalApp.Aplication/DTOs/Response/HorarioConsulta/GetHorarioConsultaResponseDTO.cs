

using System.ComponentModel.DataAnnotations;

namespace MedicalApp.Aplication.DTOs.Response.HorarioConsulta
{
    public class GetHorarioConsultaResponseDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DayOfWeek DiaSemana { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public TimeSpan HoraInicio { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public TimeSpan HoraFin { get; set; }

        // Clave foránea al médico

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Medico { get; set; }
    }
}
