using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        Task<IEnumerable<Articles>> GetAllArticles();

        IEnumerable<ArticleEmblem> GetAllArticleEmblem();

        Articles GetArticle(int id);

        Task<ArticleEmblem> GetImage(int? articleId);

        bool AddArticle(Articles article);

        bool EditArticle(Articles article, int id);

        bool RemoveArticle(int id);
    }
}
