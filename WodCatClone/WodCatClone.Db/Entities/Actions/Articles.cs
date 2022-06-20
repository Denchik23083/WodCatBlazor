using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class Articles
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FullDescription { get; set; }
        
        public string Type { get; set; }

        public string Rating { get; set; }

        public int? ArticleEmblemId { get; set; }

        public ArticleEmblem ArticleEmblem { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }
    }
}
