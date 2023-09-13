using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        Task<IEnumerable<Articles>> GetAllArticlesAsync();

        Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblemAsync();

        Task<Articles?> GetArticleAsync(int id);

        Task<bool> AddArticleAsync(Articles article, User loginUser);

        Task<bool> EditArticleAsync(Articles articleToEdit, User loginUser);

        Task<bool> RemoveArticleAsync(Articles articleToRemove);
    }
}
