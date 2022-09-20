using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db.EntityConfig.CallBackConfig
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();

            builder.HasOne(_ => _.Answer)
                .WithMany()
                .HasForeignKey(b => b.AnswerId);

            builder.ToTable("Question").HasData(
                new Question { Id = 1, Name = "Как добавить результат о тренировке?", AnswerId = 1 },
                new Question { Id = 2, Name = "Как получить баллы?", AnswerId = 3 },
                new Question { Id = 3, Name = "Как присоединиться к залу?", AnswerId = 2 },
                new Question { Id = 4, Name = "Как поднятся в рейтинге игроков?", AnswerId = 4 },
                new Question { Id = 5, Name = "Какие залы можно редактировать и удалять?", AnswerId = 5 },
                new Question { Id = 6, Name = "Как начать тренировку?", AnswerId = 6 },
                new Question { Id = 7, Name = "Можно ли редактировать или удалить результат тренировки?", AnswerId = 7 },
                new Question { Id = 8, Name = "Зачем нужна программа тренировок?", AnswerId = 8 },
                new Question { Id = 9, Name = "Можно ли редактировать или удалить программу тренировок, тренировку или упражнения?", AnswerId = 9 },
                new Question { Id = 10, Name = "Как получить баллы за мероприятие?", AnswerId = 10 });
        }
    }
}
