
using MedicalApp.Aplication.DTOs.Response.BaseResponseDTO;
using System.ComponentModel.DataAnnotations;


namespace MedicalApp.Aplication.DTOs.Response.Empleado
{
    public class GetEmpleadoResponseDTO : TrabajadorResponseDTO
    {
        //public virtual ICollection<GetEmpleadoResponseDTO>? Empleados { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? RoleEmpleado { get; set; } //Role of the employee (e.g., doctor, nurse, admin, etc.)


    }
}
