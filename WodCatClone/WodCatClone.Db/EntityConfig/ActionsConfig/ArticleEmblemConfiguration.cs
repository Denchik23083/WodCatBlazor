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
        }
    }
}
