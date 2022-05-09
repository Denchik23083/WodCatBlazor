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
        }
    }
}
