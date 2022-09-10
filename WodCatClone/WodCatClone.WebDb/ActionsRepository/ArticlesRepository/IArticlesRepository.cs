using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        Task<IEnumerable<Articles>> GetAllArticles();

        Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem();

        Task<Articles> GetArticle(int id);

        Task<ArticleEmblem> GetImage(int? articleId);

        Task<bool> AddArticle(Articles article);

        Task<bool> EditArticle(Articles article, int id);

        Task<bool> RemoveArticle(int id);
    }
}
