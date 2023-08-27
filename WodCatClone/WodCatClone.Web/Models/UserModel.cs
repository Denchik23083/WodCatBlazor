using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.Models
{
    public class UserModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Surname { get; set; }

        [Required]
        public int? GenderId { get; set; }

        [Required]
        public Gender? Gender { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string? Town { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        public string? AboutMe { get; set; }

        public int? HallId { get; set; }

        public Halls? Halls { get; set; }
    }
}
