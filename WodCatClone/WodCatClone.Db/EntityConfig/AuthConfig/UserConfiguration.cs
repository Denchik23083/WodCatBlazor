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

            builder.HasIndex(_ => new { _.Email, _.NickName }).IsUnique();

            builder.HasIndex(_ => _.Email).IsUnique();

            builder.HasIndex(_ => _.NickName).IsUnique();

            builder.HasOne(_ => _.Gender)
                .WithMany()
                .HasForeignKey(b => b.GenderId);

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(b => b.HallId);

            builder.HasOne(_ => _.Programs)
                .WithMany()
                .HasForeignKey(b => b.ProgramId);

            builder.HasOne(_ => _.Events)
                .WithMany()
                .HasForeignKey(b => b.EventId);

            builder.ToTable("User").HasData(
                new User
                {
                    Id = 1,
                    Name = "Денис",
                    Surname = "Кудрявов",
                    NickName = "SoEasyBlef",
                    Email = "deniskudravov228@gmail.com",
                    Password = "0000",
                    Country = "Ukraine",
                    Town = "Херсон",
                    Points = 185,
                    Birthday = new DateTime(2003, 08, 23),
                    Height = "185",
                    Weight = "70",
                    AboutMe = "I am a developer C#",
                    GenderId = 1
                },
                new User
                {
                    Id = 2,
                    Name = "Наташа",
                    Surname = "Возникова",
                    NickName = "Nat25",
                    Email = "nata@gmail.com",
                    Password = "0000",
                    Country = "Ukraine",
                    Town = "Херсон",
                    Points = 45,
                    Birthday = new DateTime(2000, 08, 29),
                    Height = "175",
                    Weight = "55",
                    AboutMe = "Test Nata",
                    GenderId = 2
                },
                new User
                {
                    Id = 3,
                    Name = "Trevor",
                    Surname = "Philips",
                    NickName = "GTA V",
                    Email = "trevor@gmail.com",
                    Password = "0000",
                    Country = "Ukraine",
                    Town = "Херсон",
                    Points = 185,
                    Birthday = new DateTime(2013, 09, 17),
                    Height = "190",
                    Weight = "80",
                    AboutMe = "I am a developer C#",
                    GenderId = 1,
                    ProgramId = 2,
                    HallId = 2
                });
        }
    }
}
