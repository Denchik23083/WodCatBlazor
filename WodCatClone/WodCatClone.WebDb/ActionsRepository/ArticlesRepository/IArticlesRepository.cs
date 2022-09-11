using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        IEnumerable<Articles> GetAllArticles();

        IEnumerable<ArticleEmblem> GetAllArticleEmblem();

        Articles GetArticle(int id);

        ArticleEmblem GetImage(int? articleId);

        bool AddArticle(Articles article);

        bool EditArticle(Articles article, int id);

        bool RemoveArticle(int id);
    }
}
