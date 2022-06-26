using System;

namespace WodCatClone.Db.Entities.Actions
{
    public class Events
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Town { get; set; }

        public string TypeEvent { get; set; }

        public string TypeSport { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime RegisterDate { get; set; }

        public int? HallId { get; set; }

        public Halls Halls { get; set; }
    }
}
