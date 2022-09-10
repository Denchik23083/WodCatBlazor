using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Articles>> GetAllArticles()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem()
        {
            return await _context.ArticleEmblem.ToListAsync();
        }

        public async Task<Articles> GetArticle(int id)
        {
            return await _context.Articles.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<ArticleEmblem> GetImage(int? articleId)
        {
            return await _context.ArticleEmblem.FirstOrDefaultAsync(b => b.Id == articleId);
        }

        public async Task<bool> AddArticle(Articles article)
        {
            var loginUser = UserRepository.UserRepository.User;
            var user = await _context.Users.FirstOrDefaultAsync(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            article.UserId = user.Id;

            await _context.Articles.AddAsync(article);
            user.Points += 50;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditArticle(Articles article, int id)
        {
            var loginUser = UserRepository.UserRepository.User;
            var user = await _context.Users.FirstOrDefaultAsync(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            var articleToEdit= await _context.Articles.FirstOrDefaultAsync(b => b.Id == id);

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

            user.Points += 25;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveArticle(int id)
        {
            var articleToRemove = await _context.Articles.FirstOrDefaultAsync(b => b.Id == id);

            if (articleToRemove is null)
            {
                return false;
            }

            _context.Articles.Remove(articleToRemove);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
