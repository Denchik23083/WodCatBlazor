using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class Programs
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Rating { get; set; }

        public string? Description { get; set; }

        public string? Type { get; set; }

        public string? Aim { get; set; }

        public int? ProgramsEmblemId { get; set; }

        public ProgramEmblem? ProgramEmblem { get; set; }

        public int? HallId { get; set; }

        public Halls? Halls { get; set; }

        public List<User>? Users { get; set; }

        public List<ProgramsWorkouts>? ProgramsWorkouts { get; set; }

        public List<ProgramTimeUser>? ProgramTimeUsers { get; set; }
    }
}
