﻿

namespace MedicalApp.Aplication.DTOs.Request.BaseEntity
{
    public abstract class TrabajadorRequestDTO : PersonaRequestDTO
    {
        /* Relación uno a muchos con Vacacion
       Se comenta hasta que se cree el DTO de Vacacion*/

        //[Required]
        //public List<CreateVacacionRequestDTO> Vacaciones { get; set; } = new List<CreateVacacionRequestDTO>();
    }
}
