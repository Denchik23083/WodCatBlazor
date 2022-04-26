﻿namespace WodCatClone.Db.Entities.Actions
{
    public class Articles
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FullDescription { get; set; }
        
        public string Type { get; set; }

        public string Rating { get; set; }

        public int ArticlesEmblemId { get; set; }

        public ArticlesEmblem ArticleEmblem { get; set; }
    }
}