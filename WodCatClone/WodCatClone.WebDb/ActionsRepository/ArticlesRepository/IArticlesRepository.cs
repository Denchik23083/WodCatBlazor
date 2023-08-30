using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        Task<IEnumerable<Articles>> GetAllArticles();

        Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem();

        Task<Articles?> GetArticle(int id);

        Task<bool> AddArticle(Articles article, User loginUser);

        Task<bool> EditArticle(Articles article, User loginUser);

        Task<bool> RemoveArticle(Articles articleToRemove);
    }
}
