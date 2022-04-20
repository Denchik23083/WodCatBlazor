using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly WodCatCloneContext _context;

        public ArticlesRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Articles> GetAllArticles()
        {
            return _context.Articles;
        }

        public Articles GetArticle(int id)
        {
            return _context.Articles.FirstOrDefault(b => b.Id == id);
        }

        public ArticlesEmblem GetImage(int articleId)
        {
            return _context.ArticlesEmblem.FirstOrDefault(b => b.Id == articleId);
        }
    }
}
