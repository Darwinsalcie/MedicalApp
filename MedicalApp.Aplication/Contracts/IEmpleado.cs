using MedicalApp.Aplication.DTOs.Request.Empleado;
using MedicalApp.Aplication.DTOs.Response;
using MedicalApp.Aplication.DTOs.Response.Empleado;

namespace MedicalApp.Aplication.Contracts
{
    public interface IEmpleado
    {
        Task<GeneralResponse> AddEmpleado(CreateEmpleadoRequestDTO model);
        Task<IEnumerable<GetEmpleadoResponseDTO>> GetEmpleados();
        Task<GetEmpleadoResponseDTO> GetEmpleadoById(int id);
        Task<GeneralResponse> UpdateEmpleado(UpdateEmpleadoRequestDTO model);
        Task<GeneralResponse> DeleteEmpleado(int id);
    }
}
