using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class EventsConfiguration : IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Town).IsRequired();
            builder.Property(_ => _.Location);
            builder.Property(_ => _.TypeEvent);
            builder.Property(_ => _.TypeSport);
            builder.Property(_ => _.Description);
            builder.Property(_ => _.StartDate);
            builder.Property(_ => _.EndDate);
            builder.Property(_ => _.RegisterDate);

            builder.HasOne(_ => _.EventEmblem)
                .WithMany()
                .HasForeignKey(_ => _.EventsEmblemId);

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(_ => _.HallId);

            builder.HasOne(_ => _.Workouts)
                .WithMany()
                .HasForeignKey(_ => _.WorkoutId);

            builder.HasOne(_ => _.User)
                .WithMany()
                .HasForeignKey(b => b.UserId);
        }
    }
}
