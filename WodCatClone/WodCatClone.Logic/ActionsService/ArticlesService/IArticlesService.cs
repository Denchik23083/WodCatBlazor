using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public interface IArticlesService
    {
        IEnumerable<Articles> GetAllArticles();

        IEnumerable<ArticleEmblem> GetAllArticleEmblem();

        Articles GetArticle(int id);

        string GetImage(int? articleId);

        bool AddArticle(Articles article);

        bool EditArticle(Articles article, int id);

        bool RemoveArticle(int id);
    }
}
