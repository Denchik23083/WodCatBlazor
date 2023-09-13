using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public interface IArticlesService
    {
        Task<IEnumerable<Articles>> GetAllArticlesAsync();

        Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblemAsync();

        Task<Articles?> GetArticleAsync(int id);

        Task<bool> AddArticleAsync(Articles article);

        Task<bool> EditArticleAsync(Articles article, int id);

        Task<bool> RemoveArticleAsync(int id);
    }
}
