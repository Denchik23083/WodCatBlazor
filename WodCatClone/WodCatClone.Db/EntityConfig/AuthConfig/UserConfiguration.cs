using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.EntityConfig.AuthConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Surname).HasMaxLength(255);
            builder.Property(_ => _.NickName).HasMaxLength(255);
            builder.Property(_ => _.Email).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Password).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Country).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Town).HasMaxLength(255);
            builder.Property(_ => _.Points).IsRequired().HasDefaultValue(0);
            builder.Property(_ => _.Birthday);
            builder.Property(_ => _.Weight).HasMaxLength(255);
            builder.Property(_ => _.Height).HasMaxLength(255);
            builder.Property(_ => _.AboutMe);

            builder.HasOne(_ => _.Gender)
                .WithMany()
                .HasForeignKey(b => b.GenderId);

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(b => b.HallId);
        }
    }
}
