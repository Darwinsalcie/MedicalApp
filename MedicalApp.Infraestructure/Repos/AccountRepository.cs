
using MedicalApp.Aplication.Contracts;
using MedicalApp.Aplication.DTOs.Request;
using MedicalApp.Aplication.DTOs.Request.Account;
using MedicalApp.Aplication.DTOs.Response;
using MedicalApp.Aplication.DTOs.Response.Account;

namespace MedicalApp.Infraestructure.Repos
{
    public class AccountRepository(
        ) : IAccount
    {

        public Task<GeneralResponse> ChangeRoleAsync(ChangeUserRoleRequestDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> CreateACcountAsybc(CreateAccountDTO model)
        {
            throw new NotImplementedException();
        }

        public Task CreateAdmin()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetRoleDTO>> GetRoleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetUserWithRolesReponseDTO>> GetUserWithRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> LoginAsync(LoginDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> RefreshTokenAsync(RefreshTokenDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
