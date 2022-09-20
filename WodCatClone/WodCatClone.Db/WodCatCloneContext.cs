using Microsoft.EntityFrameworkCore;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db
{
    public class WodCatCloneContext : DbContext
    {
        public WodCatCloneContext(DbContextOptions<WodCatCloneContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public DbSet<WorkoutsExercises> WorkoutsExercises { get; set; }

        public DbSet<Programs> Programs { get; set; }

        public DbSet<ProgramEmblem> ProgramEmblem { get; set; }

        public DbSet<Workouts> Workouts { get; set; }

        public DbSet<Exercises> Exercises { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<EventEmblem> EventEmblem { get; set; }

        public DbSet<EventTimeUser> EventTimeUser { get; set; }

        public DbSet<ProgramTimeUser> ProgramTimeUser { get; set; }

        public DbSet<ResultWorkouts> ResultWorkouts { get; set; }

        public DbSet<Halls> Halls { get; set; }

        public DbSet<HallEmblem> HallEmblem { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<ArticleEmblem> ArticleEmblem { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Answer> Answer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
