using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class HallsConfiguration : IEntityTypeConfiguration<Halls>
    {
        public void Configure(EntityTypeBuilder<Halls> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Town).IsRequired();
            builder.Property(_ => _.Location);
            builder.Property(_ => _.Type);
            builder.Property(_ => _.Rating);
            builder.Property(_ => _.Description);

            builder.HasOne(_ => _.EmblemHall)
                .WithMany()
                .HasForeignKey(b => b.EmblemHallId);

            builder.HasOne(_ => _.User)
                .WithMany()
                .HasForeignKey(b => b.UserId);
        }
    }
}
