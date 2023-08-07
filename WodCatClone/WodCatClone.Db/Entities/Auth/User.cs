using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.Entities.Auth
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Surname { get; set; }

        [Required]
        public string? NickName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? Town { get; set; }

        public int Points { get; set; }

        public DateTime Birthday { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        public string? AboutMe { get; set; }

        public int? GenderId { get; set; }

        public Gender? Gender { get; set; } 
        
        public int? HallId { get; set; }

        public Halls? Halls { get; set; }

        public int? ProgramId { get; set; }

        public Programs? Programs { get; set; }

        public int? EventId { get; set; }

        public Events? Events { get; set; }

        public List<EventTimeUser>? EventTimeUsers { get; set; }

        public List<ProgramTimeUser>? ProgramTimeUsers { get; set; }
    }
}
