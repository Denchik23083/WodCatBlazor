using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        IEnumerable<Articles> GetAllArticles();

        IEnumerable<ArticlesEmblem> GetAllArticlesEmblem();

        Articles GetArticle(int id);

        ArticlesEmblem GetImage(int articleId);

        bool AddArticle(Articles article);

        bool RemoveArticle(int id);
    }
}
