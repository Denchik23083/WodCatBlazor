﻿using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class ArticlesTest
    {
        [Fact]
        public void GetAllArticlesTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var articles = context.Articles;
            Assert.NotNull(articles);

            Assert.Equal(2, articles.Count());
        }

        [Fact]
        public void GetAllArticlesEmblemTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var articlesEmblem = context.ArticlesEmblem;
            Assert.NotNull(articlesEmblem);

            Assert.Equal(5, articlesEmblem.Count());
        }

        [Fact]
        public void GetArticleTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 1; 

            var article = context.Articles.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(article);

            Assert.Equal(id, article.Id);
        }

        [Fact]
        public void GetImageTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 2;
            var image = "img/EmblemArticles/Functional.png";

            var articleEmblem = context.ArticlesEmblem.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(articleEmblem);

            Assert.Equal(id, articleEmblem.Id);
            Assert.Equal(image, articleEmblem.Image);
        }

        [Fact]
        public void AddArticleTest()
        {
            var context = new TestsWodCatCloneDbContext();
            
            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newArticle = new Articles
            {
                Name = "Test",
                ArticlesEmblemId = 2,
                Description = "TestDescription",
                FullDescription = "TestFullDescription",
                Rating = "9.5",
                Type = "Статьи,Тренировки",
                UserId = user.Id
            };

            context.Articles.Add(newArticle);
            context.SaveChanges();

            var addedNewArticle = context.Articles.FirstOrDefault(b => b.Name == newArticle.Name
            && b.Description == newArticle.Description && b.FullDescription == newArticle.FullDescription
            && b.Rating == newArticle.Rating && b.Type == newArticle.Type);
            
            Assert.NotNull(addedNewArticle);

            context.Articles.Remove(addedNewArticle);
            context.SaveChanges();

            var articleAfterRemove = context.Articles.FirstOrDefault(b => b.Name == newArticle.Name
            && b.Description == newArticle.Description && b.FullDescription == newArticle.FullDescription
            && b.Rating == newArticle.Rating && b.Type == newArticle.Type);

            Assert.Null(articleAfterRemove);

            userPoint += 50;
            user.Points += 50;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void UpdateArticleTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newArticle = new Articles
            {
                Name = "Test",
                ArticlesEmblemId = 2,
                Description = "TestDescription",
                FullDescription = "TestFullDescription",
                Rating = "9.5",
                Type = "Статьи,Тренировки",
                UserId = user.Id
            };

            context.Articles.Add(newArticle);
            context.SaveChanges();

            var editArticle = new Articles
            {
                Name = "Test2",
                ArticlesEmblemId = 2,
                Description = "TestDescription2",
                FullDescription = "TestFullDescription2",
                Rating = "8.5",
                Type = "Тренировки,Статьи",
            };

            var articleToUpdate = context.Articles.FirstOrDefault(b => b.Name == newArticle.Name
            && b.Description == newArticle.Description && b.FullDescription == newArticle.FullDescription
            && b.Rating == newArticle.Rating && b.Type == newArticle.Type);

            Assert.NotNull(articleToUpdate);

            articleToUpdate.Name = editArticle.Name;
            articleToUpdate.ArticlesEmblemId = editArticle.ArticlesEmblemId;
            articleToUpdate.Description = editArticle.Description;
            articleToUpdate.FullDescription = editArticle.FullDescription;
            articleToUpdate.Rating = editArticle.Rating;
            articleToUpdate.Type = editArticle.Type;

            context.SaveChanges();

            var articleAfterUpdate = context.Articles.FirstOrDefault(b => b.Name == editArticle.Name
            && b.Description == editArticle.Description && b.FullDescription == editArticle.FullDescription
            && b.Rating == editArticle.Rating && b.Type == editArticle.Type);

            Assert.NotNull(articleAfterUpdate);

            context.Articles.Remove(articleAfterUpdate);
            context.SaveChanges();

            var articleAfterUpdateRemove = context.Articles.FirstOrDefault(b => b.Name == editArticle.Name
            && b.Description == editArticle.Description && b.FullDescription == editArticle.FullDescription
            && b.Rating == editArticle.Rating && b.Type == editArticle.Type);

            Assert.Null(articleAfterUpdateRemove);

            userPoint += 25;
            user.Points += 25;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void RemoveArticleTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            Assert.NotNull(user);

            var newArticle = new Articles
            {
                Name = "Test",
                ArticlesEmblemId = 2,
                Description = "TestDescription",
                FullDescription = "TestFullDescription",
                Rating = "9.5",
                Type = "Статьи,Тренировки",
                UserId = user.Id
            };

            context.Articles.Add(newArticle);
            context.SaveChanges();

            var articleToRemove = context.Articles.FirstOrDefault(b => b.Name == newArticle.Name 
            && b.Description == newArticle.Description && b.FullDescription == newArticle.FullDescription
            && b.Rating == newArticle.Rating && b.Type == newArticle.Type);

            Assert.NotNull(articleToRemove);

            context.Articles.Remove(articleToRemove);
            context.SaveChanges();

            var articleAfterRemove = context.Articles.FirstOrDefault(b => b.Name == newArticle.Name
            && b.Description == newArticle.Description && b.FullDescription == newArticle.FullDescription
            && b.Rating == newArticle.Rating && b.Type == newArticle.Type);
            
            Assert.Null(articleAfterRemove);
        }

        private User HelperUserLogin(TestsWodCatCloneDbContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                         l.Password == login.Password);

            return user;
        }
    }
}
