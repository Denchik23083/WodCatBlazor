using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class WorkoutsConfiguration : IEntityTypeConfiguration<Workouts>
    {
        public void Configure(EntityTypeBuilder<Workouts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Category).IsRequired();
            builder.Property(x => x.Complexity).IsRequired();
            builder.Property(x => x.Modality).IsRequired();
            builder.Property(_ => _.Minutes).IsRequired();
            builder.Property(_ => _.Seconds).IsRequired();

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(_ => _.HallId);
        }
    }
}