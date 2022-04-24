using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.EntityConfig.AuthConfig
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Image).IsRequired();
        }
    }
}
