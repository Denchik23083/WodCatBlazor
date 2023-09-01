using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class Events
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Town { get; set; }

        public string? TypeEvent { get; set; }

        public string? TypeSport { get; set; }

        public string? Location { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }

        public int? EventsEmblemId { get; set; }

        public EventEmblem? EventEmblem { get; set; }

        public int? HallId { get; set; }

        public Halls? Halls { get; set; }

        public int? WorkoutId { get; set; }

        public Workouts? Workouts { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

        public List<EventTimeUser>? EventTimeUsers { get; set; }

        public List<User>? Users { get; set; }
    }
}
