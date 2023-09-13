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

        public async Task<IEnumerable<Articles>> GetAllArticlesAsync()
        {
            return await _repository.GetAllArticlesAsync();
        }

        public async Task<IEnumerable<ArticleEmblem>> GetAllArticleEmblemAsync()
        {
            return await _repository.GetAllArticleEmblemAsync();
        }

        public async Task<Articles?> GetArticleAsync(int id)
        {
            return await _repository.GetArticleAsync(id);
        }

        public async Task<bool> AddArticleAsync(Articles article)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            article.UserId = loginUser.Id;

            loginUser.Points += 50;

            return await _repository.AddArticleAsync(article, loginUser);
        }

        public async Task<bool> EditArticleAsync(Articles article, int id)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var articleToEdit = await _repository.GetArticleAsync(id);

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

            return await _repository.EditArticleAsync(articleToEdit, loginUser);
        }

        public async Task<bool> RemoveArticleAsync(int id)
        {
            var articleToRemove = await _repository.GetArticleAsync(id);

            if (articleToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveArticleAsync(articleToRemove);
        }
    }
}
