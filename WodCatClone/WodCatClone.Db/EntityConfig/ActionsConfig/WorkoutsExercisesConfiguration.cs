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

            builder.ToTable("WorkoutsExercises").HasData(
                new WorkoutsExercises
                {
                    Id = 1,
                    WorkoutsId = 1,
                    ExercisesId = 4,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 2,
                    WorkoutsId = 2,
                    ExercisesId = 2,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 3,
                    WorkoutsId = 2,
                    ExercisesId = 3,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 4,
                    WorkoutsId = 2,
                    ExercisesId = 5,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 5,
                    WorkoutsId = 2,
                    ExercisesId = 5,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 6,
                    WorkoutsId = 2,
                    ExercisesId = 6,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 7,
                    WorkoutsId = 2,
                    ExercisesId = 7,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 8,
                    WorkoutsId = 2,
                    ExercisesId = 8,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 9,
                    WorkoutsId = 2,
                    ExercisesId = 9,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 10,
                    WorkoutsId = 2,
                    ExercisesId = 10,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 11,
                    WorkoutsId = 2,
                    ExercisesId = 11,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 12,
                    WorkoutsId = 2,
                    ExercisesId = 12,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 13,
                    WorkoutsId = 3,
                    ExercisesId = 1,
                    Work = "1000 meters"
                },
                new WorkoutsExercises
                {
                    Id = 14,
                    WorkoutsId = 3,
                    ExercisesId = 7,
                    Work = "50"
                },
                new WorkoutsExercises
                {
                    Id = 15,
                    WorkoutsId = 3,
                    ExercisesId = 11,
                    Work = "50"
                },
                new WorkoutsExercises
                {
                    Id = 16,
                    WorkoutsId = 4,
                    ExercisesId = 1,
                    Work = "300 meters"
                },
                new WorkoutsExercises
                {
                    Id = 17,
                    WorkoutsId = 4,
                    ExercisesId = 9,
                    Work = "75"
                },
                new WorkoutsExercises
                {
                    Id = 18,
                    WorkoutsId = 4,
                    ExercisesId = 12,
                    Work = "75"
                },
                new WorkoutsExercises
                {
                    Id = 19,
                    WorkoutsId = 4,
                    ExercisesId = 3,
                    Work = "75"
                },
                new WorkoutsExercises
                {
                    Id = 20,
                    WorkoutsId = 4,
                    ExercisesId = 7,
                    Work = "75"
                },
                new WorkoutsExercises
                {
                    Id = 21,
                    WorkoutsId = 5,
                    ExercisesId = 10,
                },
                new WorkoutsExercises
                {
                    Id = 22,
                    WorkoutsId = 6,
                    ExercisesId = 5,
                    Work = "10"
                },
                new WorkoutsExercises
                {
                    Id = 23,
                    WorkoutsId = 6,
                    ExercisesId = 7,
                    Work = "20"
                },
                new WorkoutsExercises
                {
                    Id = 24,
                    WorkoutsId = 6,
                    ExercisesId = 8,
                    Work = "100"
                },
                new WorkoutsExercises
                {
                    Id = 25,
                    WorkoutsId = 7,
                    ExercisesId = 12,
                    Work = "10"
                },
                new WorkoutsExercises
                {
                    Id = 26,
                    WorkoutsId = 7,
                    ExercisesId = 9,
                    Work = "20"
                });
        }
    }
}
