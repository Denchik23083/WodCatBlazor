using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ResultWorkoutsConfiguration : IEntityTypeConfiguration<ResultWorkouts>
    {
        public void Configure(EntityTypeBuilder<ResultWorkouts> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Minutes);
            builder.Property(_ => _.Seconds);
            builder.Property(_ => _.Comment);
            builder.Property(_ => _.Repeat);
            builder.Property(_ => _.Fascination);
            builder.Property(_ => _.Load);
            builder.Property(_ => _.PublishDate);

            builder.HasOne(_ => _.Workouts)
                .WithMany()
                .HasForeignKey(_ => _.WorkoutId);
        }
    }
}
