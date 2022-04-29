using System;

namespace WodCatClone.Db.Entities.Auth
{
    public class Register
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string NickName { get; set; }

        public int GenderId { get; set; }

        public DateTime Birthday { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
