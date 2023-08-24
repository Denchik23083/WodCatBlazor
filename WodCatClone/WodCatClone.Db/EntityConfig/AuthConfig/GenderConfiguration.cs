using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Core;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.EntityConfig.AuthConfig
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Type).HasConversion<int>();
            builder.Property(_ => _.Image).IsRequired();

            builder.ToTable("Gender").HasData(
                new Gender { Id = 1, Type = GenderType.Male, Image = "img/man.png" },
                new Gender { Id = 2, Type = GenderType.Female, Image = "img/woman.png" });
        }
    }
}
