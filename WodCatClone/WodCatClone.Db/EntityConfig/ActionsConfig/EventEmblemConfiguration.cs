using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class EventEmblemConfiguration : IEntityTypeConfiguration<EventEmblem>
    {
        public void Configure(EntityTypeBuilder<EventEmblem> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Image).IsRequired();
        }
    }
}
