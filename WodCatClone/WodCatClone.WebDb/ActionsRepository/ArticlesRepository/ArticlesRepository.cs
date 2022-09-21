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

        public IEnumerable<ArticleEmblem> GetAllArticleEmblem()
        {
            return _context.ArticleEmblem;
        }

        public Articles GetArticle(int id)
        {
            return _context.Articles.FirstOrDefault(b => b.Id == id);
        }

        public ArticleEmblem GetImage(int? articleId)
        {
            return _context.ArticleEmblem.FirstOrDefault(b => b.Id == articleId);
        }

        public bool AddArticle(Articles article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();

            return true;
        }

        public bool EditArticle(Articles article, int id)
        {
            var articleToEdit = _context.Articles.FirstOrDefault(b => b.Id == id);

            if (articleToEdit is null)
            {
                return false;
            }

            articleToEdit.Name = article.Name;
            articleToEdit.Type = article.Type;
            articleToEdit.ArticleEmblemId = article.ArticleEmblemId;
            articleToEdit.Rating = article.Rating;
            articleToEdit.Description = article.Description;
            articleToEdit.FullDescription = article.FullDescription;

            _context.SaveChanges();

            return true;
        }

        public bool RemoveArticle(int id)
        {
            var articleToRemove = _context.Articles.FirstOrDefault(b => b.Id == id);

            if (articleToRemove is null)
            {
                return false;
            }

            _context.Articles.Remove(articleToRemove);
            _context.SaveChanges();

            return true;
        }
    }
}
