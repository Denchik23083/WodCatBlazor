using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class EventTimeUserConfiguration : IEntityTypeConfiguration<EventTimeUser>
    {
        public void Configure(EntityTypeBuilder<EventTimeUser> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Time);

            builder.HasOne(_ => _.Events)
                .WithMany(_ => _.EventTimeUsers)
                .HasForeignKey(b => b.EventsId);

            builder.HasOne(_ => _.User)
                .WithMany(_ => _.EventTimeUsers)
                .HasForeignKey(b => b.UserId);
        }
    }
}
