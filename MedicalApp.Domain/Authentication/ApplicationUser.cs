
using Microsoft.AspNetCore.Identity;


namespace MedicalApp.Domain.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
