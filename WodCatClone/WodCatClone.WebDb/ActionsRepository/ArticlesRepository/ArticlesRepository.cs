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

        public IEnumerable<ArticlesEmblem> GetAllArticlesEmblem()
        {
            return _context.ArticlesEmblem;
        }

        public Articles GetArticle(int id)
        {
            return _context.Articles.FirstOrDefault(b => b.Id == id);
        }

        public ArticlesEmblem GetImage(int articleId)
        {
            return _context.ArticlesEmblem.FirstOrDefault(b => b.Id == articleId);
        }

        public bool AddArticle(Articles article)
        {
            _context.Articles.Add(article);

            var loginUser = UserRepository.UserRepository.User;
            var user = _context.Users.FirstOrDefault(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            user.Points += 50;

            _context.SaveChanges();

            return true;
        }
    }
}
