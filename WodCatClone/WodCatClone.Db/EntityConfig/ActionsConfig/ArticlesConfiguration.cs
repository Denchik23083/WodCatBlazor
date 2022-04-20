using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ArticlesConfiguration : IEntityTypeConfiguration<Articles>
    {
        public void Configure(EntityTypeBuilder<Articles> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Description);
            builder.Property(_ => _.Rating);
            builder.Property(_ => _.FullDescription).IsRequired();
            builder.Property(_ => _.Type).IsRequired();


            builder.HasOne(_ => _.ArticleEmblem)
                .WithMany()
                .HasForeignKey(b => b.ArticlesEmblemId);
        }
    }
}
