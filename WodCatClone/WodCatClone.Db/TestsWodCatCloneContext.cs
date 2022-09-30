using System;
using Microsoft.EntityFrameworkCore;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db
{
    public class TestsWodCatCloneContext : DbContext
    {
        public TestsWodCatCloneContext() { }

        public TestsWodCatCloneContext(DbContextOptions<TestsWodCatCloneContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public DbSet<WorkoutsExercises> WorkoutsExercises { get; set; }

        public DbSet<Programs> Programs { get; set; }

        public DbSet<ProgramEmblem> ProgramEmblem { get; set; }

        public DbSet<Workouts> Workouts { get; set; }

        public DbSet<Exercises> Exercises { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<EventTimeUser> EventTimeUser { get; set; }

        public DbSet<ProgramTimeUser> ProgramTimeUser { get; set; }

        public DbSet<EventEmblem> EventEmblem { get; set; }

        public DbSet<ResultWorkouts> ResultWorkouts { get; set; }

        public DbSet<Halls> Halls { get; set; }

        public DbSet<HallEmblem> HallEmblem { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<ArticleEmblem> ArticleEmblem { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Answer> Answer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestsWodCatCloneDb;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillDataForTests(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        private void FillDataForTests(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>().ToTable("Events").HasData(
                new Events
                {
                    Id = 1,
                    Name = "TONUS 2022 help UA",
                    TypeEvent = "Соревнования",
                    TypeSport = "Кроссфит",
                    Description = "К ТОНУС Стадион СЛАВУТИЧ АРЕНА Категории : SCALED, RX (ELITE), MASTERS 1 день 3 завдання Стартовый взнос - 500 грн Запись на участие В DIRECT!!! Для тихого, что из-за различных причин, не возможно прийняти участів в змаганнях, ми пропонуємо ОНЛАЙН ФОРМАТ. БЕЗ ВИДЕО! БЕЗ НАШЕГО СУДДІВСТВА ! ВСЕ НА НАШИЙ ДОВІРІ та ВАШІЙ ПОРЯДНОСТІ ! УМОВИ : Рестрация - 300 грн Категории - RX (ЭЛИТА) SCALED MASTERS 35 - 39, 40 - 44, 45+ 3 ( три комплекса) за один день Анонс 24.06 в п'ятницю ввечері о 17:00 Вконання 25.06 - субота . Отправить результаты до 17:00 субботы 25.06. Оголошення результатов у понедельника 27.06 Для записи напишите в DIRECT: Прізвище, им'я Місто, клуб Категорію",
                    Town = "Запорожье",
                    Location = "улица Лобановского, 21",
                    RegisterDate = new DateTime(2022, 06, 27, 10, 00, 00),
                    StartDate = new DateTime(2022, 06, 26, 12, 30, 00),
                    EndDate = new DateTime(2022, 06, 26, 15, 00, 00),
                    HallId = 1,
                    EventsEmblemId = 2,
                    UserId = 1,
                    WorkoutId = 3
                });

            modelBuilder.Entity<EventTimeUser>().ToTable("EventTimeUser").HasData(
                new EventTimeUser
                {
                    Id = 1,
                    Time = new TimeSpan(00, 37, 50),
                    EventsId = 1,
                    UserId = 1
                });

            modelBuilder.Entity<ProgramTimeUser>().ToTable("ProgramTimeUser").HasData(
                new ProgramTimeUser
                {
                    Id = 1,
                    BeginProgramDate = DateTime.Now,
                    ProgramsId = 1,
                    UserId = 1
                });

            modelBuilder.Entity<ResultWorkouts>().ToTable("ResultWorkouts").HasData(
                new ResultWorkouts
                {
                    Id = 1,
                    Time = new TimeSpan(00, 30, 30),
                    Comment = "TestsComment",
                    Repeat = 300,
                    Fascination = 5,
                    Load = 5,
                    PublishDate = new DateTime(2000, 12, 5),
                    WorkoutId = 1,
                    UserId = 1
                });
        }
    }
}
