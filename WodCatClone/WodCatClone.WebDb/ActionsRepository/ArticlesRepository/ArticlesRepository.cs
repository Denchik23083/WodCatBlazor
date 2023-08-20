using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly WodCatCloneContext _context;

        public ArticlesRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Articles>> GetAllArticles()
        {
            return await _context.Articles
                .Include(_ => _.ArticleEmblem)
                .ToListAsync();
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

        public bool AddArticle(Articles article, User user)
        {
            article.UserId = user.Id;

            _context.Articles.Add(article);

            user.Points += 50;

            _context.SaveChanges();

            return true;
        }

        public bool EditArticle(Articles article, Articles articleToEdit, User user)
        {
            articleToEdit.Name = article.Name;
            articleToEdit.Type = article.Type;
            articleToEdit.ArticleEmblemId = article.ArticleEmblemId;
            articleToEdit.Rating = article.Rating;
            articleToEdit.Description = article.Description;
            articleToEdit.FullDescription = article.FullDescription;

            user.Points += 25;

            _context.SaveChanges();

            return true;
        }

        public bool RemoveArticle(Articles articleToRemove)
        {
            _context.Articles.Remove(articleToRemove);
            _context.SaveChanges();

            return true;
        }
    }
}
