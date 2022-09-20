using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ProgramsConfiguration : IEntityTypeConfiguration<Programs>
    {
        public void Configure(EntityTypeBuilder<Programs> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Type).IsRequired();
            builder.Property(_ => _.Aim).IsRequired();
            builder.Property(_ => _.Description);
            builder.Property(_ => _.Rating);

            builder.HasOne(_ => _.ProgramEmblem)
                .WithMany()
                .HasForeignKey(b => b.ProgramsEmblemId);

            builder.HasOne(_ => _.Halls)
                .WithMany()
                .HasForeignKey(_ => _.HallId);

            builder.ToTable("Programs").HasData(
                new Programs
                {
                    Id = 1,
                    Name = "Программа тренировки кроссфит на массу",
                    Rating = "8.0",
                    Description = "Программа тренировок состоит из 38 комплексов с большим преобладанием коротких силовых тренировок и полным отсутствием кардио нагрузки. План тренировок подойдет, если ваша цель - увеличение силы и прирост мышечной масса в ущерб выносливости. План тренировок комбинирует в себе силовые тренировки и короткие “тяжелые” комплексы кроссфит, преобладают базовые упражнения с большими весами на малое кол-во повторов, что является основным условием развития силы и набора массы (мышечной массы) В данной программе встречаются технически сложные тяжелоатлетические упражнения, поэтому обязательно пр...",
                    Type = "Кроссфит",
                    Aim = "Набор мышечной массы",
                    HallId = 1,
                    ProgramsEmblemId = 3
                },
                new Programs
                {
                    Id = 2,
                    Name = "Plan for the amateur",
                    Description = "План, для аматоров CrossFit План для тренировок в зале с использованием упражнений на силу и выносливость, состоящая в основном из аэробных упражнений, гимнастики (упражнения с весом собственного тела) и тяжёлой атлетики, для людей которые имеют слабую или среднюю базовую подготовку, с целью поддержания и увеличиния физической формы. Если твой уровень выше чем этот то тебе на этот план------> CoachMarchenko",
                    Type = "Тяжелая атлетика",
                    Aim = "На силу",
                    ProgramsEmblemId = 5
                },
                new Programs
                {
                    Id = 3,
                    Name = "Кроссфит программа тренировок дома без оборудования",
                    Description = "Программа тренировок идеально подойдет для новичков. Большая часть плана состоит из гимнастических тренировок со своим весом и не требует вспомогательных предметов для выполнения. Сами же упражнения очень просты и наверняка давно вам знакомы, поэтому вы можете не обладать специальными знаниями, чтобы заниматься по данному плану. С этой программой вам не нужно обязательно быть в зале во время тренировки, вы можете выполнять тренировки в любом удобном месте.",
                    Type = "Кроссфит",
                    Aim = "Fitness",
                    HallId = 2,
                    ProgramsEmblemId = 1
                },
                new Programs
                {
                    Id = 4,
                    Name = "Вводной план тренировок для новичков в Кроссфите",
                    Description = "План тренировки рассчитан на людей решивших начать тренировки по системе Кроссфит. Тренировочный план сбалансированный, используются только базовые и упрощенные упражнения. Но если Вы не имеете опыта выполнения данных упражнений, обязательно выполнение данного плана под руководством сертифицированного тренера",
                    Type = "Кроссфит",
                    Aim = "Fitness",
                    HallId = 3,
                    Rating = "10.0",
                    ProgramsEmblemId = 2
                },
                new Programs
                {
                    Id = 5,
                    Name = "NRC 21.1 Prep",
                    Type = "Фитнесс",
                    Aim = "Performance",
                    ProgramsEmblemId = 4
                });
        }
    }
}
