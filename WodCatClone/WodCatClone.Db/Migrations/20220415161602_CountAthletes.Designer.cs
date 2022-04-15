﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WodCatClone.Db;

namespace WodCatClone.Db.Migrations
{
    [DbContext(typeof(WodCatCloneContext))]
    [Migration("20220415161602_CountAthletes")]
    partial class CountAthletes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.Exercises", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Complexity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inventory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Movement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.HallEmblem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HallEmblem");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.Halls", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Athletes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmblemHallId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmblemHallId");

                    b.HasIndex("UserId");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.ResultWorkouts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fascination")
                        .HasColumnType("int");

                    b.Property<int>("Load")
                        .HasColumnType("int");

                    b.Property<string>("Minutes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Repeat")
                        .HasColumnType("int");

                    b.Property<string>("Seconds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("ResultWorkouts");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.Workouts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complexity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmblemHallId")
                        .HasColumnType("int");

                    b.Property<string>("Exercises")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inventory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Minutes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Movement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seconds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmblemHallId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Points")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.Halls", b =>
                {
                    b.HasOne("WodCatClone.Db.Entities.Actions.HallEmblem", "EmblemHall")
                        .WithMany()
                        .HasForeignKey("EmblemHallId");

                    b.HasOne("WodCatClone.Db.Entities.Auth.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("EmblemHall");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.ResultWorkouts", b =>
                {
                    b.HasOne("WodCatClone.Db.Entities.Actions.Workouts", "Workouts")
                        .WithMany()
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Actions.Workouts", b =>
                {
                    b.HasOne("WodCatClone.Db.Entities.Actions.HallEmblem", "EmblemHall")
                        .WithMany()
                        .HasForeignKey("EmblemHallId");

                    b.Navigation("EmblemHall");
                });

            modelBuilder.Entity("WodCatClone.Db.Entities.Auth.User", b =>
                {
                    b.HasOne("WodCatClone.Db.Entities.Actions.Halls", "Halls")
                        .WithMany()
                        .HasForeignKey("HallId");

                    b.Navigation("Halls");
                });
#pragma warning restore 612, 618
        }
    }
}
