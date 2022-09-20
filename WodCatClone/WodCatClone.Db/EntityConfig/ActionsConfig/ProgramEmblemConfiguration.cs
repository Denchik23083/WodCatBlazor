using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ProgramEmblemConfiguration : IEntityTypeConfiguration<ProgramEmblem>
    {
        public void Configure(EntityTypeBuilder<ProgramEmblem> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Image).IsRequired();

            builder.ToTable("ProgramEmblem").HasData(
                new ProgramEmblem { Id = 1, Name = "BallMan", Image = "img/EmblemPrograms/BallMan.png" },
                new ProgramEmblem { Id = 2, Name = "GymMan", Image = "img/EmblemPrograms/GymMan.png" },
                new ProgramEmblem { Id = 3, Name = "Men", Image = "img/EmblemPrograms/Men.png" },
                new ProgramEmblem { Id = 4, Name = "NRC", Image = "img/EmblemPrograms/NRC.png" },
                new ProgramEmblem { Id = 5, Name = "Wod", Image = "img/EmblemPrograms/Wod.png" });
        }
    }
}
