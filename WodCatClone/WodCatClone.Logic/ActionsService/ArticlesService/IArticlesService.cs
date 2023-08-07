using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public interface IArticlesService
    {
        IEnumerable<Articles> GetAllArticles();

        IEnumerable<ArticleEmblem> GetAllArticleEmblem();

        Articles GetArticle(int id);

        string GetImage(int? articleId);

        Task<bool> AddArticle(Articles article);

        Task<bool> EditArticle(Articles article, int id);

        bool RemoveArticle(int id);
    }
}
