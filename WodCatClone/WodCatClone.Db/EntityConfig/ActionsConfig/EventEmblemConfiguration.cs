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

            builder.ToTable("EventEmblem").HasData(
                new EventEmblem { Id = 1, Name = "Fon", Image = "img/EmblemEvents/fon.jpg" },
                new EventEmblem { Id = 2, Name = "Idi", Image = "img/EmblemEvents/idi.jpg" },
                new EventEmblem { Id = 3, Name = "Lime", Image = "img/EmblemEvents/lime.jpg" },
                new EventEmblem { Id = 4, Name = "Run", Image = "img/EmblemEvents/run.jpg" },
                new EventEmblem { Id = 5, Name = "Sport", Image = "img/EmblemEvents/sport.jpg" });
        }
    }
}
