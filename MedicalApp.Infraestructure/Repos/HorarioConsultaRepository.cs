

using MedicalApp.Aplication.Contracts;
using MedicalApp.Aplication.DTOs.Request.HorarioConsulta;
using MedicalApp.Aplication.DTOs.Response;
using MedicalApp.Aplication.DTOs.Response.HorarioConsulta;
using MedicalApp.Infraestructure.Data;


namespace MedicalApp.Infraestructure.Repos
{
    public class HorarioConsultaRepository(AppDbContext context) : IHorarioConsulta
    {
        /*
         implementar el repositorio de HorarioConsulta
         */

        public Task<GeneralResponse> AddHorarioConsulta(CreateHorarioConsultaRequestDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteHorarioConsulta(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetHorarioConsultaRequestDTO>> GetHorarioConsulta()
        {
            throw new NotImplementedException();
        }

        public Task<GetHorarioConsultaResponseDTO> GetHorarioConsultaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> UpdateHorarioConsulta(UpdateHorarioConsultaRequestDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
