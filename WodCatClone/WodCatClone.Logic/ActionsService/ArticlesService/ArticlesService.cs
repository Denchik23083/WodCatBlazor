﻿using System.Collections.Generic;
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

        public IEnumerable<Articles> GetAllArticles()
        {
            return _repository.GetAllArticles();
        }

        public Articles GetArticle(int id)
        {
            return _repository.GetArticle(id);
        }

        public string GetImage(int articleId)
        {
            var article = _repository.GetImage(articleId);

            return article.Image;
        }
    }
}