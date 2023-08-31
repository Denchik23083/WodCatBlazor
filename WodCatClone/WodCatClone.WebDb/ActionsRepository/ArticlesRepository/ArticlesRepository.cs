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

        public async Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem()
        {
            return await _context.ArticleEmblem.ToListAsync();
        }

        public async Task<Articles?> GetArticle(int id)
        {
            return await _context.Articles
                .Include(_ => _.ArticleEmblem)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> AddArticle(Articles article, User loginUser)
        {
            await _context.Articles.AddAsync(article);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditArticle(Articles articleToEdit, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveArticle(Articles articleToRemove)
        {
            _context.Articles.Remove(articleToRemove);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
