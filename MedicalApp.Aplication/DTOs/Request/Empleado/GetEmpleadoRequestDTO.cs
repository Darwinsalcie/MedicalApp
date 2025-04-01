using MedicalApp.Aplication.DTOs.Request.BaseRequestDTO;


namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class GetEmpleadoRequestDTO : TrabajadorRequestDTO
    {
        public RolEmpleado Rol { get; set; }
        
    }
}
