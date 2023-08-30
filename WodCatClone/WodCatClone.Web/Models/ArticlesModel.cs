using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.Models
{
    public class ArticlesModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? FullDescription { get; set; }

        public string? Type { get; set; }

        public string? Rating { get; set; }

        public int? ArticleEmblemId { get; set; }

        public ArticleEmblem? ArticleEmblem { get; set; }
    }
}
