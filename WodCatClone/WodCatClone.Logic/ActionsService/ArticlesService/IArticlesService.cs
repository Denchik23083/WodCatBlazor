using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public interface IArticlesService
    {
        Task<IEnumerable<Articles>> GetAllArticles();

        IEnumerable<ArticleEmblem> GetAllArticleEmblem();

        Articles GetArticle(int id);

        Task<string> GetImage(int? articleId);

        bool AddArticle(Articles article);

        bool EditArticle(Articles article, int id);

        bool RemoveArticle(int id);
    }
}
