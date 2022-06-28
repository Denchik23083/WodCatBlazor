using System;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.Entities.Auth
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Country { get; set; }

        public string Town { get; set; }

        public int Points { get; set; }

        public DateTime Birthday { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public string AboutMe { get; set; }

        public int? GenderId { get; set; }

        public Gender Gender { get; set; } 
        
        public int? HallId { get; set; }

        public Halls Halls { get; set; }

        public int? ProgramId { get; set; }

        public Programs Programs { get; set; }

        public int? EventId { get; set; }

        public Events Events { get; set; }
    }
}
