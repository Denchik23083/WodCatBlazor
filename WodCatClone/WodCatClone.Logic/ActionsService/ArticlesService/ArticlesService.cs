using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.ArticlesRepository;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public class ArticlesService : IArticlesService
    {
        private readonly IArticlesRepository _repository;

        public ArticlesService(IArticlesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Articles>> GetAllArticles()
        {
            return await _repository.GetAllArticles();
        }

        public async Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem()
        {
            return await _repository.GetAllArticleEmblem();
        }

        public async Task<Articles> GetArticle(int id)
        {
            return await _repository.GetArticle(id);
        }

        public async Task<string> GetImage(int? articleId)
        {
            var article = await _repository.GetImage(articleId);

            return article.Image;
        }

        public async Task<bool> AddArticle(Articles article)
        {
            return await _repository.AddArticle(article);
        }

        public async Task<bool> EditArticle(Articles article, int id)
        {
            return await _repository.EditArticle(article, id);
        }

        public async Task<bool> RemoveArticle(int id)
        {
            return await _repository.RemoveArticle(id);
        }
    }
}
