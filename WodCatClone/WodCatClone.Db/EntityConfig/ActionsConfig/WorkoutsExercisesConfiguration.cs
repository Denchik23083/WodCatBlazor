using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class WorkoutsExercisesConfiguration : IEntityTypeConfiguration<WorkoutsExercises>
    {
        public void Configure(EntityTypeBuilder<WorkoutsExercises> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Work);

            builder.HasOne(_ => _.Workouts)
                .WithMany(_ => _.WorkoutsExercises)
                .HasForeignKey(b => b.WorkoutsId);

            builder.HasOne(_ => _.Exercises)
                .WithMany(_ => _.WorkoutsExercises)
                .HasForeignKey(b => b.ExercisesId);
        }
    }
}
