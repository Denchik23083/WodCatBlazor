using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class WorkoutsConfiguration : IEntityTypeConfiguration<Workouts>
    {
        public void Configure(EntityTypeBuilder<Workouts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Category).IsRequired();
            builder.Property(x => x.Complexity).IsRequired();
            builder.Property(x => x.Modality).IsRequired();
            builder.Property(_ => _.Time).IsRequired();

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(_ => _.HallId);

            builder.ToTable("Workouts").HasData(
                new Workouts
                {
                    Id = 1,
                    Name = "100 Burpees",
                    Rating = "7.0",
                    Category = "Singlet,Bodyweight,For-Time",
                    Complexity = "Легкий",
                    Modality = "G",
                    Time = new TimeSpan(00, 23, 20),
                    HallId = 1
                },
                new Workouts
                {
                    Id = 2,
                    Name = "1000",
                    Rating = "8.5",
                    Category = "Couplet,Bodyweight,For-Time",
                    Complexity = "Сложный",
                    Modality = "GM",
                    Time = new TimeSpan(00, 50, 30),
                    HallId = 4
                },
                new Workouts
                {
                    Id = 3,
                    Name = "Titan wod",
                    Rating = "10.0",
                    Category = "Couplet,Bodyweight,ForTime,Rower",
                    Complexity = "Нормальный",
                    Modality = "GM",
                    Time = new TimeSpan(00, 24, 00),
                    HallId = 1
                },
                new Workouts
                {
                    Id = 4,
                    Name = "Вместе Навсегда",
                    Rating = "8.0",
                    Category = "Couplet,ForTime,Kettlebell",
                    Complexity = "Нормальный",
                    Modality = "WM",
                    Time = new TimeSpan(00, 16, 25),
                    HallId = 2
                },
                new Workouts
                {
                    Id = 5,
                    Name = "Jumping300",
                    Rating = "6.5",
                    Category = "Endurance,Singlet,AMRAP",
                    Complexity = "Легкий",
                    Modality = "M",
                    Time = new TimeSpan(00, 05, 00),
                    HallId = 4
                },
                new Workouts
                {
                    Id = 6,
                    Name = "Siberian Bears",
                    Rating = "7.5",
                    Category = "Triplet,For-Time",
                    Complexity = "Нормальный",
                    Modality = "WGM",
                    Time = new TimeSpan(00, 19, 00),
                    HallId = 3
                },
                new Workouts
                {
                    Id = 7,
                    Name = "08022014",
                    Rating = "8.0",
                    Category = "Couplet,For-Time",
                    Complexity = "Легкий",
                    Modality = "WG",
                    Time = new TimeSpan(00, 29, 06),
                    HallId = 5
                });
        }
    }
}