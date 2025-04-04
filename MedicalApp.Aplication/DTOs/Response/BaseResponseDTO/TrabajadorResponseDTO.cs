

namespace MedicalApp.Aplication.DTOs.Response.BaseResponseDTO
{
    public abstract class TrabajadorResponseDTO : PersonaResponseDTO
    {
        /* Relación uno a muchos con Vacacion
     Se comenta hasta que se cree el DTO de Vacacion*/

        //[Required]
        //public List<CreateVacacionRequestDTO> Vacaciones { get; set; } = new List<CreateVacacionRequestDTO>();
    }
}
