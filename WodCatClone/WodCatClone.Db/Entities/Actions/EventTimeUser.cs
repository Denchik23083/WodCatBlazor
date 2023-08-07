using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class EventTimeUser
    {
        public int Id { get; set; }

        public TimeSpan Time { get; set; }

        public int EventsId { get; set; }

        public Events Events { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
