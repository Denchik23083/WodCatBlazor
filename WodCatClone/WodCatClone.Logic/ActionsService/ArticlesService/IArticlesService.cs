using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public interface IArticlesService
    {
        Task<IEnumerable<Articles>> GetAllArticles();

        Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem();

        Task<Articles?> GetArticle(int id);

        Task<bool> AddArticle(Articles article);

        Task<bool> EditArticle(Articles article, int id);

        Task<bool> RemoveArticle(int id);
    }
}
