

using System.ComponentModel.DataAnnotations;


namespace MedicalApp.Aplication.DTOs.Request.Account
{

    public class LoginDTO
    {
        [EmailAddress, Required]
        [Display(Name = "Email Address")]
        [RegularExpression(RegexPatterns.EmailPattern, ErrorMessage = "Invalid email format.")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression(RegexPatterns.PasswordPattern, ErrorMessage = "Password must have at least 8 characters, including 1 uppercase letter, 1 lowercase letter, 1 number, and 1 special character.")]
        public string Password { get; set; }
    }



}


