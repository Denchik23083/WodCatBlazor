﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ResultWorkoutsConfiguration : IEntityTypeConfiguration<ResultWorkouts>
    {
        public void Configure(EntityTypeBuilder<ResultWorkouts> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Minutes).IsRequired();
            builder.Property(_ => _.Seconds).IsRequired();
            builder.Property(_ => _.Comment);
            builder.Property(_ => _.Repeat).IsRequired();
            builder.Property(_ => _.Fascination).IsRequired();
            builder.Property(_ => _.Load).IsRequired();
            builder.Property(_ => _.PublishDate).IsRequired();

            builder.HasOne(_ => _.Workouts)
                .WithMany()
                .HasForeignKey(_ => _.WorkoutId);
        }
    }
}