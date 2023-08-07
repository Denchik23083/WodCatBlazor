using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class ProgramTimeUser
    {
        public int Id { get; set; }

        public DateTime BeginProgramDate { get; set; }

        public int ProgramsId { get; set; }

        public Programs? Programs { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }
    }
}
