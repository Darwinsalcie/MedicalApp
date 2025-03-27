
using System.ComponentModel.DataAnnotations;


namespace MedicalApp.Aplication.DTOs.Request.Account
{
    public class CreateAccountDTO : LoginDTO
    {
        public string? Role { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required, Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
    }
}
