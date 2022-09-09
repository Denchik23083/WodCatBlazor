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

        public IEnumerable<ArticleEmblem> GetAllArticleEmblem()
        {
            return _repository.GetAllArticleEmblem();
        }

        public Articles GetArticle(int id)
        {
            return _repository.GetArticle(id);
        }

        public async Task<string> GetImage(int? articleId)
        {
            var article = await _repository.GetImage(articleId);

            return article.Image;
        }

        public bool AddArticle(Articles article)
        {
            return _repository.AddArticle(article);
        }

        public bool EditArticle(Articles article, int id)
        {
            return _repository.EditArticle(article, id);
        }

        public bool RemoveArticle(int id)
        {
            return _repository.RemoveArticle(id);
        }
    }
}
