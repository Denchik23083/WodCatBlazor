namespace WodCatClone.Db.Entities.Auth
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Country { get; set; }

        public string Town { get; set; }
    }
}
