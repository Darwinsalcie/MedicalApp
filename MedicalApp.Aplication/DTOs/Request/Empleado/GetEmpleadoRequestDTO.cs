using MedicalApp.Aplication.DTOs.Request.BaseEntity;
using System.ComponentModel.DataAnnotations;


namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class GetEmpleadoRequestDTO : TrabajadorRequestDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public RolEmpleado Rol { get; set; }
        
    }
}
