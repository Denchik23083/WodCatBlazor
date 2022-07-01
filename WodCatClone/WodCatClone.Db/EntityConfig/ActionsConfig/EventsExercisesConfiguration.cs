using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class EventsExercisesConfiguration : IEntityTypeConfiguration<EventsExercises>
    {
        public void Configure(EntityTypeBuilder<EventsExercises> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.HasOne(_ => _.Events)
                .WithMany(_ => _.EventsExercises)
                .HasForeignKey(b => b.EventsId);

            builder.HasOne(_ => _.Exercises)
                .WithMany(_ => _.EventsExercises)
                .HasForeignKey(b => b.ExercisesId);
        }
    }
}
