using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ArticlesRepository
{
    public interface IArticlesRepository
    {
        IEnumerable<Articles> GetAllArticles();

        Articles GetArticle(int id);

        ArticlesEmblem GetImage(int articleId);
    }
}
