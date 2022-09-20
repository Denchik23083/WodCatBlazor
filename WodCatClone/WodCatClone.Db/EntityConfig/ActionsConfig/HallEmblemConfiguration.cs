using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class HallEmblemConfiguration : IEntityTypeConfiguration<HallEmblem>
    {
        public void Configure(EntityTypeBuilder<HallEmblem> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Image).IsRequired();

            builder.ToTable("HallEmblem").HasData(
                new HallEmblem { Id = 1, Name = "Dog", Image = "img/EmblemHalls/Dog.png" },
                new HallEmblem { Id = 2, Name = "M4", Image = "img/EmblemHalls/M4.png" },
                new HallEmblem { Id = 3, Name = "Olimp", Image = "img/EmblemHalls/Olimp.png" },
                new HallEmblem { Id = 4, Name = "BlasArea", Image = "img/EmblemHalls/BlasArea.png" },
                new HallEmblem { Id = 5, Name = "Banda", Image = "img/EmblemHalls/Banda.png" });
        }
    }
}
