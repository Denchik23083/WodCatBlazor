using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        IEnumerable<Articles> GetAllArticles();

        IEnumerable<ArticleEmblem> GetAllArticleEmblem();

        Articles GetArticle(int id);

        ArticleEmblem GetImage(int? articleId);

        bool AddArticle(Articles article, User user);

        bool EditArticle(Articles article, Articles articleToEdit, User user);

        bool RemoveArticle(Articles articleToRemove);
    }
}
