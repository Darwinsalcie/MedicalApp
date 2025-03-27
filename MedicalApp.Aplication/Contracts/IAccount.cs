

using MedicalApp.Aplication.DTOs.Request;
using MedicalApp.Aplication.DTOs.Request.Account;
using MedicalApp.Aplication.DTOs.Response;
using MedicalApp.Aplication.DTOs.Response.Account;

namespace MedicalApp.Aplication.Contracts
{
    public interface IAccount
    {
        Task CreateAdmin();
        Task<GeneralResponse> CreateACcountAsybc(CreateAccountDTO model);
        Task<LoginResponse> LoginAsync(LoginDTO model);
        Task<LoginResponse> RefreshTokenAsync(RefreshTokenDTO model);
        Task<IEnumerable<GetRoleDTO>> GetRoleAsync();
    }
}
