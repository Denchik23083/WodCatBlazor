using System.ComponentModel.DataAnnotations;

namespace WodCatClone.Db.Entities.Auth
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
