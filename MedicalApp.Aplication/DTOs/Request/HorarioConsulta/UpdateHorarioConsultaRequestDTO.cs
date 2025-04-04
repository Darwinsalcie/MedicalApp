



using MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO;
using System.ComponentModel.DataAnnotations;







/*
  
 


 Crear Abstraciones correspondientes a la entidad HorarioConsulta
basandose en los campos comunes



 */



namespace MedicalApp.Aplication.DTOs.Request.HorarioConsulta
{
    public class UpdateHorarioConsultaRequestDTO : AuditUpdateRequestDTO
    {
        [Required(ErrorMessage = "El campo Id es requerido.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DayOfWeek DiaSemana { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public TimeSpan HoraInicio { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public TimeSpan HoraFin { get; set; }

        // Clave foránea al médico
        //Implementar con una propiedad de navegación
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int MedicoId { get; set; }
    }
}
