using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ArticleEmblemConfiguration : IEntityTypeConfiguration<ArticleEmblem>
    {
        public void Configure(EntityTypeBuilder<ArticleEmblem> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Image).IsRequired();

            builder.ToTable("ArticleEmblem").HasData(
                new ArticleEmblem { Id = 1, Name = "Buildhome", Image = "img/EmblemArticles/buildhome.png" },
                new ArticleEmblem { Id = 2, Name = "Functional", Image = "img/EmblemArticles/Functional.png" },
                new ArticleEmblem { Id = 3, Name = "OvercomeDoubt", Image = "img/EmblemArticles/OvercomeDoubt.png" },
                new ArticleEmblem { Id = 4, Name = "TwoMen", Image = "img/EmblemArticles/TwoMen.png" },
                new ArticleEmblem { Id = 5, Name = "Provides", Image = "img/EmblemArticles/provides.png" });
        }
    }
}
