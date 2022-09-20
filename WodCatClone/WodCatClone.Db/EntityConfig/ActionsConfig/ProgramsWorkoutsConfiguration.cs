using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ProgramsWorkoutsConfiguration : IEntityTypeConfiguration<ProgramsWorkouts>
    {
        public void Configure(EntityTypeBuilder<ProgramsWorkouts> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.HasOne(_ => _.Programs)
                .WithMany(_ => _.ProgramsWorkouts)
                .HasForeignKey(b => b.ProgramsId);

            builder.HasOne(_ => _.Workouts)
                .WithMany(_ => _.ProgramsWorkouts)
                .HasForeignKey(b => b.WorkoutsId);

            builder.ToTable("ProgramsWorkouts").HasData(
                new ProgramsWorkouts
                {
                    Id = 1,
                    ProgramsId = 1,
                    WorkoutsId = 1
                },
                new ProgramsWorkouts
                {
                    Id = 2,
                    ProgramsId = 1,
                    WorkoutsId = 2
                },
                new ProgramsWorkouts
                {
                    Id = 3,
                    ProgramsId = 1,
                    WorkoutsId = 3
                },
                new ProgramsWorkouts
                {
                    Id = 4,
                    ProgramsId = 2,
                    WorkoutsId = 1
                },
                new ProgramsWorkouts
                {
                    Id = 5,
                    ProgramsId = 2,
                    WorkoutsId = 3
                },
                new ProgramsWorkouts
                {
                    Id = 6,
                    ProgramsId = 3,
                    WorkoutsId = 2
                },
                new ProgramsWorkouts
                {
                    Id = 7,
                    ProgramsId = 3,
                    WorkoutsId = 5
                },
                new ProgramsWorkouts
                {
                    Id = 8,
                    ProgramsId = 4,
                    WorkoutsId = 2
                },
                new ProgramsWorkouts
                {
                    Id = 9,
                    ProgramsId = 4,
                    WorkoutsId = 3
                },
                new ProgramsWorkouts
                {
                    Id = 10,
                    ProgramsId = 4,
                    WorkoutsId = 4
                },
                new ProgramsWorkouts
                {
                    Id = 11,
                    ProgramsId = 5,
                    WorkoutsId = 1
                },
                new ProgramsWorkouts
                {
                    Id = 12,
                    ProgramsId = 5,
                    WorkoutsId = 5
                });
        }
    }
}
