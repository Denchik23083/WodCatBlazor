using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ProgramsConfiguration : IEntityTypeConfiguration<Programs>
    {
        public void Configure(EntityTypeBuilder<Programs> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Type).IsRequired();
            builder.Property(_ => _.Aim).IsRequired();
            builder.Property(_ => _.CountUser);
            builder.Property(_ => _.Description);
            builder.Property(_ => _.Image);
            builder.Property(_ => _.Rating);

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(_ => _.HallId);
        }
    }
}
