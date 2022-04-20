using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    internal class ArticlesEmblemConfiguration : IEntityTypeConfiguration<ArticlesEmblem>
    {
        public void Configure(EntityTypeBuilder<ArticlesEmblem> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Image).IsRequired();
        }
    }
}
