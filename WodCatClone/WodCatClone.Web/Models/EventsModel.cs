using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.Models
{
    public class EventsModel
    {
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
    }
}
