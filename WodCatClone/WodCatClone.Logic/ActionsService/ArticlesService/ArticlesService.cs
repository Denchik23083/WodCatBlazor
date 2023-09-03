using WodCatClone.Db.Entities.Actions;
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

        public async Task<IEnumerable<Articles>> GetAllArticles()
        {
            return await _repository.GetAllArticles();
        }

        public async Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblem()
        {
            return await _repository.GetAllArticleEmblem();
        }

        public async Task<Articles?> GetArticle(int id)
        {
            return await _repository.GetArticle(id);
        }

        public async Task<bool> AddArticle(Articles article)
        {
            var user = AuthService.AuthService.User;
            var loginUser = _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            article.UserId = loginUser.Id;

            loginUser.Points += 50;

            return await _repository.AddArticle(article, loginUser);
        }

        public async Task<bool> EditArticle(Articles article, int id)
        {
            var user = AuthService.AuthService.User;
            var loginUser = _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var articleToEdit = await _repository.GetArticle(id);

            if (articleToEdit is null)
            {
                return false;
            }

            articleToEdit.Name = article.Name;
            articleToEdit.Type = article.Type;
            articleToEdit.ArticleEmblemId = article.ArticleEmblemId;
            articleToEdit.Rating = article.Rating;
            articleToEdit.Description = article.Description;
            articleToEdit.FullDescription = article.FullDescription;

            loginUser.Points += 25;

            return await _repository.EditArticle(articleToEdit, loginUser);
        }

        public async Task<bool> RemoveArticle(int id)
        {
            var articleToRemove = await _repository.GetArticle(id);

            if (articleToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveArticle(articleToRemove);
        }
    }
}
