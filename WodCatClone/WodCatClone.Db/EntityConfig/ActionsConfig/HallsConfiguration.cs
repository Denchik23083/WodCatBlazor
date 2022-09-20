using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class HallsConfiguration : IEntityTypeConfiguration<Halls>
    {
        public void Configure(EntityTypeBuilder<Halls> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Town).IsRequired();
            builder.Property(_ => _.Location);
            builder.Property(_ => _.Type);
            builder.Property(_ => _.Rating);
            builder.Property(_ => _.Description);

            builder.HasOne(_ => _.EmblemHall)
                .WithMany()
                .HasForeignKey(b => b.EmblemHallId);

            builder.HasOne(_ => _.User)
                .WithMany()
                .HasForeignKey(b => b.UserId);

            builder.ToTable("Halls").HasData(
                new Halls
                {
                    Id = 1,
                    Name = "DOG & GRAND CROSSFIT",
                    Type = "Affiliate Crossfit,Boxing,Fitness,Gym,MMA,Yoga",
                    Town = "Киев",
                    Location = "Днепровская набережная, 14К",
                    Description = "DOG – первый фитнес клуб Киева, который получил официальную CrossFit сертификацию. Высокие стандарты обслуживания, качества оборудования и подхода к тренировкам обязательны для получения сертификации.Титулованный тренерский состав и профессиональное оборудование сделают ваши занятия более эффективными и помогут выйти на новый уровень физической подготовки.Главные тренера клубов ДОГ - Валентин Литвинчук и Леонид Леус - настоящие профессионалы которые стоят у истоков развития Кроссфита в Украине Более 50 различных & nb...",
                    EmblemHallId = 1
                },
                new Halls
                {
                    Id = 2,
                    Name = "M4",
                    Type = "Crossfit (not Aff.)",
                    Town = "Харьков",
                    Location = "пр. Тракторостроителей 57б",
                    Rating = "10.0",
                    EmblemHallId = 2
                },
                new Halls
                {
                    Id = 3,
                    Name = "Олимп",
                    Type = "Crossfit (not Aff.),Fitness,Gym,Yoga",
                    Description = "Самая крупная сеть клубов в Западной Украине. 5 специализированных залов со всем необходимым оборудованием в городе Льва. Площадь залов составляет от 400 до 2500кв.м. Залы условно поделены на зоны от кардио до тяжёлой атлетики и кроссфит зон. Качественная система вентиляции и кондиционирования делает занятия ещё эффективней. Общая сауна для отдыха.Квалифицированные тренера, которые помогут даже в скретчинге и диетологии. Олимп рекомендует Василий Вирастюк.",
                    Town = "Львов",
                    Rating = "10.0",
                    EmblemHallId = 3
                },
                new Halls
                {
                    Id = 4,
                    Name = "Crossfit Banda",
                    Type = "Affiliate Crossfit,Fitness,Gym,Weightlifting,Yoga",
                    Description = "Первая сеть кроссфит-залов в Киеве - 4 зала в разных районах города и локации для бесплатных тренировок. Самый большой из них - площадью в 1200 кв.м. Сертифицированные тренера.Физическая реабилитация после травм.Команда Banda Crossfit принимает участие в благотворительном забеге Wings for Life World Run.Клуб проводит все украинские турниры по кроссфиту Banda Arena Challenge.Скретчинг, настольный теннис для отдыха.Школа тренеров, семинары, собственная лаборатория Banda Lab.Множество мероприятий и партнёров.",
                    Rating = "5.0",
                    Town = "Киев",
                    Location = "Новопечерский переулок, 5",
                    EmblemHallId = 5
                },
                new Halls
                {
                    Id = 5,
                    Name = "BLaS CrossFit Area",
                    Type = "Affiliate Crossfit,Fitness,Gym",
                    Description = "Blas (CrossFit — BLaS CA! BLaS = Body Like a Stone) Crossfit Area, Днепр. Целый спортивный комплекс на берегу Днепра - 300 кв.м. Единственный аффилированный зал в городе.Персональные тренировки по всем направлениям, в том числе Crossfit Kids.Отличная команда тренеров.Профессиональное оборудование Rogue(3 тонны железа), кроссфит - рама, 2 Air Bikes, 10 гребных тренажёров Concept.Массажный кабинет, фитнес - бар с самыми лучшими коктейлями, детская комната, если негде оставить ребенка.",
                    Town = "Днепр",
                    Location = "улица Набережная Победы, 62",
                    EmblemHallId = 4
                });
        }
    }
}
