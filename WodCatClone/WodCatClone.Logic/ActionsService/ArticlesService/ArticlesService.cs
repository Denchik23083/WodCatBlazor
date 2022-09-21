using System.Collections.Generic;
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

        public bool AddArticle(Articles article)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            article.UserId = user.Id;

            var result = _repository.AddArticle(article);

            if (result)
            {
                user.Points += 50;
            }

            return result;
        }

        public bool EditArticle(Articles article, int id)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            var result = _repository.EditArticle(article, id);

            if (result)
            {
                user.Points += 25;
            }

            return result;
        }

        public bool RemoveArticle(int id)
        {
            return _repository.RemoveArticle(id);
        }
    }
}
