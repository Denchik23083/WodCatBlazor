using System.ComponentModel.DataAnnotations;

namespace WodCatClone.Db.Entities.Auth
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email format is not right")]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
