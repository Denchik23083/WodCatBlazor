using Microsoft.EntityFrameworkCore;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db
{
    public class WodCatCloneContext : DbContext
    {
        public WodCatCloneContext(DbContextOptions<WodCatCloneContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<ProgramsWorkouts> ProgramsWorkouts { get; set; } = null!;

        public DbSet<WorkoutsExercises> WorkoutsExercises { get; set; } = null!;

        public DbSet<Programs> Programs { get; set; } = null!;

        public DbSet<ProgramEmblem> ProgramEmblem { get; set; } = null!;

        public DbSet<Workouts> Workouts { get; set; } = null!;

        public DbSet<Exercises> Exercises { get; set; } = null!;

        public DbSet<Events> Events { get; set; } = null!;

        public DbSet<EventEmblem> EventEmblem { get; set; } = null!;

        public DbSet<EventTimeUser> EventTimeUser { get; set; } = null!;

        public DbSet<ProgramTimeUser> ProgramTimeUser { get; set; } = null!;

        public DbSet<ResultWorkouts> ResultWorkouts { get; set; } = null!;

        public DbSet<Halls> Halls { get; set; } = null!;

        public DbSet<HallEmblem> HallEmblem { get; set; } = null!;

        public DbSet<Articles> Articles { get; set; } = null!;

        public DbSet<ArticleEmblem> ArticleEmblem { get; set; } = null!;

        public DbSet<Gender> Gender { get; set; } = null!;

        public DbSet<Question> Question { get; set; } = null!;

        public DbSet<Answer> Answer { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
