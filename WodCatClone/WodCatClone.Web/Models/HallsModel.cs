using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.Models
{
    public class HallsModel
    {
        [Required]
        public string? Name { get; set; }

        public string? Type { get; set; }

        [Required]
        public string? Town { get; set; }

        public string? Location { get; set; }

        public string? Description { get; set; }

        public string? Rating { get; set; }

        public int? EmblemHallId { get; set; }

        public HallEmblem? EmblemHall { get; set; }
    }
}
