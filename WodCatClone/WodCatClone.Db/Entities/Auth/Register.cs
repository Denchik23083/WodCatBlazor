using System;
using System.ComponentModel.DataAnnotations;

namespace WodCatClone.Db.Entities.Auth
{
    public class Register
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email format is not right")]
        public string Email { get; set; }

        [Required]
        public string NickName { get; set; }

        public int GenderId { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Town { get; set; }
    }
}
