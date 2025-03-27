using MedicalApp.Aplication.DTOs.Request.Empleado;


namespace MedicalApp.Aplication.DTOs.Response.Empleado
{
    public class GetEmpleadoResponseDTO : CreateEmpleadoDTO
    {
        public int Id { get; set; }
        public virtual ICollection<GetEmpleadoResponseDTO>? Cines { get; set; }
    }
}
