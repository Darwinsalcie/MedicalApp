
using MedicalApp.Aplication.DTOs.Request.HorarioConsulta;
using MedicalApp.Aplication.DTOs.Response;
using MedicalApp.Aplication.DTOs.Response.HorarioConsulta;

namespace MedicalApp.Aplication.Contracts
{
    public interface IHorarioConsulta
    {
        Task<GeneralResponse> AddHorarioConsulta(CreateHorarioConsultaRequestDTO model);
        Task<IEnumerable<GetHorarioConsultaRequestDTO>> GetHorarioConsulta();
        Task<GetHorarioConsultaResponseDTO> GetHorarioConsultaById(int id);
        Task<GeneralResponse> UpdateHorarioConsulta(UpdateHorarioConsultaRequestDTO model);
        Task<GeneralResponse> DeleteHorarioConsulta(int id);
    }
}
