using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public interface IArticlesService
    {
        IEnumerable<Articles> GetAllArticles();

        Articles GetArticle(int id);

        string GetImage(int articleId);
    }
}
