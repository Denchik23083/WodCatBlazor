using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db.EntityConfig.CallBackConfig
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();

            builder.ToTable("Answer").HasData(
                new Answer { Id = 1, Name = "Зарегистрироваться и заполнить форму" },
                new Answer { Id = 2, Name = "Зайти в залы и присоединиться" },
                new Answer { Id = 3, Name = "Баллы дают за создание нового зала, новой статьи, добавление результата о тренировке, за прохождении программы и мероприятия" },
                new Answer { Id = 4, Name = "Зарабатывать баллы" },
                new Answer { Id = 5, Name = "Только те, которые создал" },
                new Answer { Id = 6, Name = "Зайти на тренировку и нажать старт и еще раз старт" },
                new Answer { Id = 7, Name = "Да" },
                new Answer { Id = 8, Name = "Каждый день будет переключаться на следующую тренировку, пока тренировки в этой программе не закончатся. После вам добавят 50 очков" },
                new Answer { Id = 9, Name = "Нет" },
                new Answer { Id = 10, Name = "Регистрируйтесь на мероприятие, потом проходите задание и вводите ваше время. Лучшие 3 участника получат баллы" });
        }
    }
}
