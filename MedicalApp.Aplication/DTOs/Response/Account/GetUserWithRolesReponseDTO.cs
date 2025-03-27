

namespace MedicalApp.Aplication.DTOs.Response.Account
{
    public class GetUserWithRolesReponseDTO
    {
        public string? RoleId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? RoleName { get; set; }
       // public List<GetRoleDTO> Roles { get; set; }
    }
}
