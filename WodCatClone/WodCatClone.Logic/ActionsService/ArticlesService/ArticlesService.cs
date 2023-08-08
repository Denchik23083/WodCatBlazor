using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.ArticlesRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.ArticlesService
{
    public class ArticlesService : IArticlesService
    {
        private readonly IArticlesRepository _repository;
        private readonly IUserRepository _userRepository;

        public ArticlesService(IArticlesRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public IEnumerable<Articles> GetAllArticles()
        {
            return _repository.GetAllArticles();
        }

        public IEnumerable<ArticleEmblem> GetAllArticleEmblem()
        {
            return _repository.GetAllArticleEmblem();
        }

        public Articles GetArticle(int id)
        {
            return _repository.GetArticle(id);
        }

        public string GetImage(int? articleId)
        {
            return _repository.GetImage(articleId).Image;
        }

        public async Task<bool> AddArticle(Articles article)
        {
            var loginUser = AuthService.AuthService.User;
            var user = await _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            return _repository.AddArticle(article, user);
        }

        public async Task<bool> EditArticle(Articles article, int id)
        {
            var loginUser = AuthService.AuthService.User;
            var user = await _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            var articleToEdit = _repository.GetArticle(id);

            if (articleToEdit is null)
            {
                return false;
            }

            return _repository.EditArticle(article, articleToEdit, user);
        }

        public bool RemoveArticle(int id)
        {
            var articleToRemove = _repository.GetArticle(id);

            if (articleToRemove is null)
            {
                return false;
            }

            return _repository.RemoveArticle(articleToRemove);
        }
    }
}
