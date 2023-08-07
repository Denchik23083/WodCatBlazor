namespace WodCatClone.Db.Entities.CallBack
{
    public class Question
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int AnswerId { get; set; }

        public Answer? Answer { get; set; }
    }
}
