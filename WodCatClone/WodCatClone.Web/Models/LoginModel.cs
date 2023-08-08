using System.ComponentModel.DataAnnotations;

namespace WodCatClone.Web.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email format is not right")]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
