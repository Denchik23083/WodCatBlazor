using System;
using Microsoft.EntityFrameworkCore;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db
{
    public class TestsWodCatCloneDbContext : DbContext
    {
        public TestsWodCatCloneDbContext() { }

        public TestsWodCatCloneDbContext(DbContextOptions<TestsWodCatCloneDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>().ToTable("Answer").HasData(
                new Answer { Id = 1, Name = "Зарегестрироваться" },
                new Answer { Id = 2, Name = "Зайти в залы и присоединиться" },
                new Answer { Id = 3, Name = "Баллы дают за создание нового зала и добовление результата о тренировке" },
                new Answer { Id = 4, Name = "Заробатывать баллы" },
                new Answer { Id = 5, Name = "Только те, которые создал?" },
                new Answer { Id = 6, Name = "Зайти на тренировку и нажать старт и еще раз старт" });

            modelBuilder.Entity<Gender>().ToTable("Gender").HasData(
                new Gender { Id = 1, Name = "Мужской", Image = "img/man.png" },
                new Gender { Id = 2, Name = "Женский", Image = "img/woman.png" });

            modelBuilder.Entity<ArticlesEmblem>().ToTable("ArticlesEmblem").HasData(
                new ArticlesEmblem { Id = 1, Name = "Buildhome", Image = "img/EmblemArticles/buildhome.png" },
                new ArticlesEmblem { Id = 2, Name = "Functional", Image = "img/EmblemArticles/Functional.png" },
                new ArticlesEmblem { Id = 3, Name = "OvercomeDoubt", Image = "img/EmblemArticles/OvercomeDoubt.png" },
                new ArticlesEmblem { Id = 4, Name = "TwoMen", Image = "img/EmblemArticles/TwoMen.png" },
                new ArticlesEmblem { Id = 5, Name = "Provides", Image = "img/EmblemArticles/provides.png" });

            modelBuilder.Entity<HallEmblem>().ToTable("HallEmblem").HasData(
                new HallEmblem { Id = 1, Name = "Dog", Image = "img/EmblemHalls/Dog.png" },
                new HallEmblem { Id = 2, Name = "M4", Image = "img/EmblemHalls/M4.png" },
                new HallEmblem { Id = 3, Name = "Olimp", Image = "img/EmblemHalls/Olimp.png" },
                new HallEmblem { Id = 4, Name = "BlasArea", Image = "img/EmblemHalls/BlasArea.png" },
                new HallEmblem { Id = 5, Name = "TitanBox", Image = "img/EmblemHalls/Titanbox.png" });

            modelBuilder.Entity<Question>().ToTable("Question").HasData(
                new Question { Id = 1, Name = "Как добавить результат о тренировке?", AnswerId = 1 },
                new Question { Id = 2, Name = "Как получить баллы?", AnswerId = 3 },
                new Question { Id = 3, Name = "Как присоединиться к залу?", AnswerId = 2 },
                new Question { Id = 4, Name = "Как поднятся в рейтинге игроков?", AnswerId = 4 },
                new Question { Id = 5, Name = "Какие залы можно редактировать и удалять?", AnswerId = 5 },
                new Question { Id = 6, Name = "Как начать тренировку?", AnswerId = 6 });

            modelBuilder.Entity<Articles>().ToTable("Articles").HasData(
                new Articles
                {
                    Id = 1,
                    Name = "Build a Home Gym in 2020 That You Will Actually Use",
                    Type = "Кроссфит,Статьи",
                    Description = "A Home Gym You’ll Actually Use Learn from my mistakes &the times I got it right My Home Gym Gear Shopping List for a Garage Gym",
                    FullDescription = "A Home Gym You’ll Actually Use For those new to functional training, such as CrossFit,and looking to build out your own garage gym or home gym and training space,here’s an equipment guide to get you started.My aim is to save you from buying equipment that you’ll rarely use — equipment that wastes your money and takes up valuable space.In this article,I share with you what I setup recently after I sold my CrossFit gym and wanted a place at home to train.Learn from my mistakes &the times I got it right For more than 25 years I’ve been an endurance athlete,half of that time working as a coach,I’ve either had a small gym at home or access to a great gym near home.I also built a full CrossFit gym in Switzerland,ran it for 5 years, and sold it to a great friend and trainer.After selling my gym and spending more time at home writing coaching books, I was desperate to build a home gym once again.In this article, I share with you my recommendations for equipment to buy for home that you will actually use, not one that is ego - driven or based on what looks great in an Instagram post, but is not what you will really use.I’ve purchased a wide range of equipment over the years, spanning a mix of great buying decisions and some terrible choices.I aim to guide you toward building a home gym that you’ll feel great about now, as well as in a few years.I offer my top recommendations, share what I purchased and suggest a super saver option for each item.My Home GymOf all the gyms I’ve setup over the years, this is my favorite home gym.Why ? Because it’s right where it needs to be for me to actually use it and has exactly what I need for my indoors training.I set it up in a small winter garden room.I love this gym — it has everything I want and nothing more.It’s not flashy or showy, yet it can handle the heaviest lifts I’ll ever do, high intensity training, strength training, CrossFit WODs, Hero WODs and more. I carefully selected every piece of equipment.Gear Shopping List for a Garage GymMust - Have EquipmentI’ll start with what I consider must - have gear."
                    + "Barbell – This is the most important piece of equipment you will have in your arsenal.Training trends come and go, but old school barbell strength training is timeless and extremely effective. Master these 3 movements and you will have 80 % of what you need for strength training to serve your needs for decades: Back Squat, Deadlift, Overhead Press.Grow from there into Power Cleans, Front Squats, and Thrusters.And if you discover a passion for barbell training, you’ll likely find yourself diving into the technique work required for Overhead Squats, Cleans, and Snatch.You get what you pay for, so invest in a quality bar.Check out Rogue’s Ohio Bar as a high quality starter and consider upgrade options from there only if you get very serious about Olympic Lifting.For women or anyone with smaller hands, consider a 25mm version, and for kids, newbie and rehab use, check out this option.I only wanted one barbell for our small training space at home, so I opted for the 15kg Bella Bar, which works perfectly for either of us.Super Saver Option: buy a used bar from a CrossFit gym that is going out of business or when a college or fitness center upgrades equipment.Don’t forget collars – You can get the Rogue Fitness HG collars, Rogue OSU, or a pair of good old spring collars.Squat Stand or Rack – There are many different variation for this important piece of equipment.Rogue has created some very innovative designs recently.I love their Monster Lite Fold Back Racks.If I had the right space for this, it’s exactly what I’d buy.If space is no concern and you want to lift heavy with maximum safety options, then have a look at a Power Rack.The first piece of equipment I bought for my first gym location was a Power Rack R - 3.For my home gym, I wanted flexibility and the option to carry the stands outside, so I opted for the S-4 model.It’s super stable and handles everything I throw at it.Super Saver Option: My very first squat stands were a pair of cheap construction stands from the local home improvement store.They weren’t elegant and not especially stable, but they did the job until I could afford stable, safer stands."
                    + "Bumper Plates – Invest in bumper plates and you won’t regret it for home use, especially if you get more into Olympic weightlifting movements. Buy the max weight you’ll realistically need and add weight if and when the time comes. I have 120kg / 265lbs of weights, as I don’t expect to ever need more than that for home use and don’t want extra plates taking up space.My favorite bumpers are Rogue HG.If you go cheap on bumpers, they won’t last and you’ll regret it.Super Saver Option: Same as with barbells: going out of business sales, upgrading equipment, etc.Kettlebells: There is some much you can do with power and strength training, as well as conditioning, with kettlebells. That’s what puts them on the must - have list.I recommend starting light, in the 12kg / 25lb range and then working your way up. My go-to kettlebell is a 53lb / 24KG Rogue Competition model. I have only 3 kettlebells in my home gym: 12kg(25lb), 16kg(35lb), and 24kg(55lb).My advice is to buy high quality kettlebells.These are heavy devices and not easy to get rid of.My first few kettlebells have terrible handles and I regret buying them.Super Saver Option: Same as with barbells and bumper plates. You may more easily find cheap used dumbbells, so start there if no cheap kettlebell options exist in your area.Important Items NOT on the Must Have ListI left off some important training equipment intentionally, as a tight budget means making tough choices. For example, a Bench is on the Nice - to - Have list.You can do floor press instead of bench press and standing overhead press instead of a seated press and wait until you’ve go the cash for a bench. Same goes for pull - ups(you can do pull - ups from a barbell placed on your squat stands).Nice - to - Have EquipmentThis list is where I’d spend hard - earned money once the must-haves are in your house.Sandbag: This is a great all - around training tool. It is simple and effective.You can buy them in all sizes and designs these days. If you opt to buy one, make sure the quality is high.I’ve seen too many sandbags bust open in real - world training.Get a good one or make one yourself that will last."
                    + "Super Saver Option: Here’s a How - to guide on making your own and some suggested sandbag workouts.Bench: simple is good.Simple and strong: even better. I recommend the Rogue Bolt Together Utility Bench. In addition to bench press and seated overhead press, you can also use a bench for core work and box step - ups(if you don’t have a plyo box).Super Saver Option: Pick up a used bench or build a very basic DIY bench yourself.Rings: If I had to choose rings over a pull - up rig, I’d choose rings any day.You can hang rings from the ceiling, from trees and other features outside, and from a barbell placed on your squat stands or rack. You can do most of the fundamental TRX movements with rings, as well as pull - ups and dips. I love classic wooden gymnastics rings. I drilled into the thick concrete ceiling of my balcony to mount my rings. Sure, get a TRX too, but make sure you’ve got rings in the gym first.Pull - up Rig: If you’ve got a place for it, then go for it.Use bands to scale the movement so that you can perform it with proper form while building strength.You can mount a pull - up bar on the wall or ceiling, use a portable system that you can hang from various things or go with a doorway option.Jump Rope: Simple, portable, great for metabolic conditioning (try 5 rounds of 90sec rope skipping + 10 burpees + 10 sit - ups for a great little workout).I have a collection of ropes for different workout types, including a custom RX, a Rogue SR - 3, and a Rogue Heavy Rope.AbMat: Lots of improvements since the first generation of these great little pieces of equipment.I have a first gen AbMat, as well as a new Wise Crack — which I’ve tested on Annie and highly endorse if you’ve ever dealt with a case of CrossFit sit - up butt rub!",
                    ArticlesEmblemId = 1
                },
                new Articles
                {
                    Id = 2,
                    Name = "article provides a few key tips on how to perform the deadlift more efficiently and safely",
                    Type = "Кроссфит,Тренировки",
                    Rating = "10.0",
                    Description = "This article provides a few key tips on how to perform the deadlift more efficiently and safely. Some helpful coaching cues—such as keeping the head slightly up, activating the lats, and pushing the knees out—can assist a tactical athlete in executing the deadlift while increasing strength over time.",
                    FullDescription = "It is becoming a more common idea that strength training should be utilized in every population for maintaining general health and varied performance goals. There is a growing body of anecdotal evidence showing the benefits of including general strength training in populations where it was previously ignored or deemed harmful. However, there is still confusion on how to best implement strength training in programs focused on sport performance, rehabilitation, or general health. Hopefully this article can provide insight and guidance on how to use one of the most important strength movements—the deadlift.The deadlift should be a staple for not only increasing performance but also overall resiliency.Almost every job in any tactical field(e.g., police, fire, military) requires stabilization of the trunk while expressing large amounts of force through the lower extremities. There are few exercises that will activate trunk muscles like the deadlift because it requires the entire body to be engaged for proper completion. The deadlift requires the upper and lower extremities to move or stabilize the bar, which engages a large number of motor units and muscles fibers simultaneously.In terms of positive changes and strength progressions in short - or long - term adaptation, there are few substitutes for the deadlift. Its simplicity and function should make it a priority in all strength training regimens.The positive changes in bone density, muscle mass, resting metabolic rate, decreased low back pain, and even dynamic strength development emphasize the importance of the deadlift(1, 2, 3).Research has also shown that long - term lifting with deadlifts and squats not only promotes an increase of bone density in younger populations, but it may also help maintain that increase well into the later stages of life(1, 4, 5).The coordinated effort required to perform the deadlift, and its variations, places a large amount of stress on the musculoskeletal system and drives adaptation.The deadlift is a base for all other ground - based lifts(e.g., cleans, snatches, and their variations) as well as many tactical agility tests(e.g., dummy drags, equipment lifting, patient loading, etc.).Proper execution of the deadlift, and the ability to stabilize the trunk and spine while exerting maximal effort is a skill that can help tactical personnel and the general population avoid injury."
                    + "The deadlift should be a staple for not only increasing performance but also overall resiliency.Almost every job in any tactical field(e.g., police, fire, military) requires stabilization of the trunk while expressing large amounts of force through the lower extremities. There are few exercises that will activate trunk muscles like the deadlift because it requires the entire body to be engaged for proper completion. The deadlift requires the upper and lower extremities to move or stabilize the bar, which engages a large number of motor units and muscles fibers simultaneously.There are a few key pointers that advanced coaches and lifters can use in order to achieve excellent results while reducing the risk of injury and promoting safe motor patterns.The remainder of this article will present four of the most important tips for deadlifting from an anecdotal base to not only increase performance, but also to decrease injury rates in tactical populations.TIP 1 | Head Posture: The Head Needs To Be Looking Slightly UpwardThere has been a lot of debate with this topic, but keeping the head looking slightly upward allows the shoulders to stay back and the spine to stay in a more erect, and neutral, position.Half of the battle with performing near - maximal deadlifts and doing it safely is keeping the back as neutral as possible with the head in a more upright position, which keeps the hips and leg extensors working at the same time.Often if the head falls forward or the eyes drift downward while performing the lift, it can cause the weight to be distributed over the leg extensors and reduce the involvement of the hips and posterior chain.It has been debated that a “head up” position can cause cervical spine issues, but research is currently lacking to warrant such concern. Hundreds, if not thousands, of powerlifters have lifted this way for many years, and cervical spine injury has not become an epidemic in this population, or been at a high enough prevalence to cause concern.A more vertical, and neutral, back position allows for increased hip drive, which can be better utilized with the head looking slightly upward.From experience, often a slightly upward head angle results in better deadlift form.TIP 2 | Lat Activation: The Lats Need to Engage First"
                    + "This allows the bar path to be as close to the legs as possible.By contracting the lats first, the bar stays closer to the lower extremities and gives the hips and legs more leverage to perform the task.The further the bar is away from the legs, the more the lower back has to activate to perform the lift.A great deadlift should leave marks on the shins.This indicates that the bar was as close to the lower extremities as possible, and the bar weight was kept as close as possible to the lifter’s center of mass.This activation of the lats can create a posture that is advantageous to lifting large loads safely by creating tension on the bar prior to initiating the lift.Advanced lifters may actually try to bend the bar with the lats while the barbell is on the ground, to ensure the bar stays close to the body.This preliminary activation of the lats also reduces the tendency for the shoulders to drop, keeping the thoracic and lumbar spine more vertical and less likely to round.TIP 3 | Knee Motion Cues: Regardless of Position(Sumo, Conventional, or Some Variation) Always Try to Push the Knees ApartPushing the knees apart throughout the deadlift can help the glutes remain active during the lift.When first learning, most people will tend to use all quads, hamstrings, and spinal erectors to pull the weight up off the ground.By driving the knees apart, the glute medius will be triggered to stabilize the pelvis and help the posterior chain to maximize hip extension.This is crucial with not only coaching, but also lifting larger loads(i.e., 80 % of one repetition maximum[1RM] or higher).This key coaching cue can allow the athlete to lift more weight by including more muscle groups throughout the entire lift.Another helpful tip is to try to spread the floor with the feet.This lateral pressure can force the knees outward and ensure a strong supportive base from which to lift.TIP 4 | Positional Weakness: Train Your Weakest PositionMany times when an athlete first starts to deadlift, one position feels more natural or stronger(usually conventional) than others. An athlete will tend to gravitate towards this stronger position naturally.However, it can be very helpful to focus on the position that feels weaker and more awkward for long - term improvement.For my tactical athletes and general clients, it is valuable for them to become proficient in sumo deadlifting before utilizing a conventional stance.There are a few reasons for this:"
                    + "It teaches the lifter to use the hips primarily, which can reduce the risk of excessive lumber flexion under load.Hip strength and mobility are crucial in general performance.One of the main indicators of future lower back problems and / or health is hip mobility. Completing sumo deadlifts correctly can aid in developing strong hips, as well as improving mobility.From experience, sumo deadlifts can actually help one learn to pull conventional deadlifts correctly, by first addressing hip mobility and learning how to maximally activate the glutes.This allows the lifter to take some pressure off the lower back and place it on the glutes.The sumo deadlift seems to be able to withstand more volume in a training block or cycle than deadlifting with a conventional stance.A logical reason for this is that the sumo stance utilizes less lower back musculature and more of the glutes.Since the glutes are larger, and more powerful, they can handle the increased training volume when compared to the lower back.From experience, the sumo deadlift can be used more frequently and with higher resistances for longer periods of time than the conventional deadlift(assuming the lifter is healthy).Hopefully this article has provided a few key tips on how to perform the deadlift more efficiently and safely.Some helpful coaching cues, like keeping the head slightly up, activating the lats, and pushing the knees out can assist a tactical athlete in executing the deadlift while increasing strength over time.",
                    ArticlesEmblemId = 2
                });

            modelBuilder.Entity<Exercises>().ToTable("Exercises").HasData(
                new Exercises
                {
                    Id = 1,
                    Name = "Бег",
                    Description = "Бег, равно как и ходьба – абсолютно естественное для организма состояние.Но начинающие бегуны могут столкнуться со множеством проблем.Оказывается,бегать – не так - то просто.Существует даже такое понятие как правильный беговой почерк.Оно подразумевает прямо поставленную голову,ровную спину,правильное расположение ног.Только когда все составляющие выдержаны,можно добиться легкого и быстрого бега.",
                    FullDescription = "Итак, какие аспекты необходимо выдерживать тем, кто стремится овладеть правильной техникой бега:- Свести вертикальные колебания тела к минимуму.Резкие удары о беговую поверхность,равно как и выбрасывания тела в воздух могут привести к сильному возрастанию нагрузки на суставы и позвоночник.- Не допускать раскачиваний тела в разные стороны.Вообще такие раскачивания могут быть,если стопы относительно друг друга стоят неправильно.Потому необходимо учиться бегать так,чтобы внутренние края стоп находились на одной линии.Допускается лишь небольшой угол,который может образовываться между носками стоп.Это позволит при толчке максимальное усилие направить на большой палец.- Правильный бег предусматривает также грамотную постановку ступней,когда они касаются поверхности земли.Специалисты выделяют три метода – вся стопа,носок - пятка и пятка - носок.Начинающие бегуны должны стремиться распределять нагрузку равномерно на всю стопу – это существенно разгрузит суставы.Правильная техника бега позволяет проверить постановку стоп таким образом: нужно провести прямую линию к беговой поверхности через центр тяжести тела.Пройти эта линия должна через центр стопы.Для сравнения,при ходьбе она проходит через пятку.Еще один момент: при касании земли стопу следует слегка напрячь.- Чтобы научиться бегать,следует также правильно подобрать длину шага.Узкий шаг не дает достаточный тонус мышцам.Тогда как чрезмерно широкий шаг увеличивает риск приземления на прямую ногу.- Верхняя часть туловища при правильном беге должна быть неподвижной.Осанку придется выдерживать,то есть не наклоняться вперед и не запрокидывать туловище назад.Все это позволит уберечь от травм суставы и позвоночник.Также следует следить за положением рук.Так,в локтях они должны быть согнуты под прямым углом,кисти должны быть слегка сжатыми.Голову также нельзя наклонять низко взгляд должен быть направлен метров на 10 - 15 вперед.- Правильная техника бега невозможна без непринужденного ритмичного дыхания – это не позволяет организму слишком рано устать.Итак,какие аспекты необходимо выдерживать тем,кто стремится овладеть правильной техникой бега:-Свести вертикальные колебания тела к минимуму.Резкие удары о беговую поверхность,равно как и выбрасывания тела в воздух могут привести к сильному возрастанию нагрузки на суставы и позвоночник."
                    + "- Не допускать раскачиваний тела в разные стороны.Вообще такие раскачивания могут быть,если стопы относительно друг друга стоят неправильно.Потому необходимо учиться бегать так,чтобы внутренние края стоп находились на одной линии.Допускается лишь небольшой угол,который может образовываться между носками стоп.Это позволит при толчке максимальное усилие направить на большой палец.- Правильный бег предусматривает также грамотную постановку ступней,когда они касаются поверхности земли.Специалисты выделяют три метода – вся стопа,носок - пятка и пятка - носок.Начинающие бегуны должны стремиться распределять нагрузку равномерно на всю стопу – это существенно разгрузит суставы.Правильная техника бега позволяет проверить постановку стоп таким образом: нужно провести прямую линию к беговой поверхности через центр тяжести тела.Пройти эта линия должна через центр стопы.Для сравнения,при ходьбе она проходит через пятку.Еще один момент: при касании земли стопу следует слегка напрячь.- Чтобы научиться бегать,следует также правильно подобрать длину шага.Узкий шаг не дает достаточный тонус мышцам.Тогда как чрезмерно широкий шаг увеличивает риск приземления на прямую ногу.- Верхняя часть туловища при правильном беге должна быть неподвижной.Осанку придется выдерживать,то есть не наклоняться вперед и не запрокидывать туловище назад.Все это позволит уберечь от травм суставы и позвоночник.Также следует следить за положением рук.Так,в локтях они должны быть согнуты под прямым углом,кисти должны быть слегка сжатыми.Голову также нельзя наклонять низко взгляд должен быть направлен метров на 10 - 15 вперед.- Правильная техника бега невозможна без непринужденного ритмичного дыхания – это не позволяет организму слишком рано устать.",
                    Complexity = "Легкий",
                    Movement = "Бег",
                    Modality = "M",
                    Inventory = "Нет",
                    Image = "https://www.youtube.com/embed/t7ZD68RKTT8"
                },
                new Exercises
                {
                    Id = 2,
                    Name = "Выход на кольцах",
                    Description = "Выход на кольцах - упражнение продвинутого уровня в кроссфите. Обычный выход на кольцах  или же (киппинг выход на кольцах), немного легче, нежели строгий вариант выходов, хотя он требует не меньших усилий в изучении. Перед тем как приступать к изучению выходов на кольцах, желательно уметь подтягиваться в строгом стиле на кольцах минимум 15 раз и уметь отжиматься на кольцах 15-20 раз, тогда вы можете быть уверены, что ваши мышцы вас не подведут.Помните,что выходы на кольцах это больше техническое,нежели силовое упражнение и чаще всего упражнение может не получатся из за нехватки опыта и техники,нежели сил! ",
                    FullDescription = "Техника выполнения упражнения: <<Выход на кольцах>>Исходное положение:-Повисните на вытянутых руках,на кольцах- Хват обычныйВыполнение упражнения:-Сделайте несколько махов телом в положении виса на кольцах- Затем сделайте достаточно сильных замах назад,выгнувшись в спине в обратную сторону.- Из положения прогиба сделайте вымах вперед,вылетая таким образом в на уровень колец.По мере приближении тела к кольцам начните разгибать тело в горизонтально ровную позицию,придавая телу инерцию.Тело от такого маха должно оказаться примерно параллельным полу.- Используя полученную энергию,подтяните себя как можно ближе к кольцам,вылетая при этом в положение упора кольцах,не гася при этом инерцию полета.- Если вам не хватило инерции и вы вылетели в положение на согнутых руках в упор,выжмите себя в положение на прямые руки используя силу трицепса и плеч,так же можно придать дополнительный импульс,делая рывок ногами.",
                    Complexity = "Нормальный",
                    Movement = "Выход на кольцах",
                    Modality = "G",
                    Inventory = "Кольца гимнастические",
                    Image = "https://www.youtube.com/embed/BQS4Kw7q7OQ"
                },
                new Exercises
                {
                    Id = 3,
                    Name = "Выбросы",
                    Description = "Выбросы со штангой или «Трастеры» - это упражнение, которое одновременно задействует большое количество крупных мышц. Данное упражнение отлично развивает как и силовые показатели так и выносливые, это зависит от того какой вес и диапазон повторений вы будете использовать в своих тренировках.Трастеры – это так же и универсальное упражнение,классический вариант исполнения,это выбросы со штангой,но вы легко можете использовать самое разнообразное оборудование(гири, гантели, мешок с песком, медболы, и т.д.).",
                    FullDescription = "Техника выполнения упражнения: «Выбросы со штангой Thrusters»Исходное положение:-Возьмите штангу в передний упор на груди,так же как в стартовой позиции для фронтальных приседаний.- Спина ровная,положение ступней на ширине плеч.- Локти подняты,взгляд направлен вперед.Выполнение упражнения:-Опуститесь в нижнее положение приседания,со штангой на груди.- Начните мощно вставать и одновременно выжимайте штангу в положение над головой,до тех пор,пока ваши руки не окажутся прямыми.- Зафиксируйте штангу на вытянутых руках,и после небольшой паузы опуститесь обратно в положение приседа,во время опускания так же опустите штангу на грудь.",
                    Complexity = "Сложный",
                    Movement = "Выбросы",
                    Modality = "W",
                    Inventory = "Штанга",
                    Image = "https://www.youtube.com/embed/aea5BGj9a8Y"
                });

            modelBuilder.Entity<Halls>().ToTable("Halls").HasData(
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
                });

            modelBuilder.Entity<Workouts>().ToTable("Workouts").HasData(
                new Workouts
                {
                    Id = 1,
                    Name = "100 Burpees",
                    Rating = "7.0",
                    Category = "Singlet,Bodyweight,For-Time",
                    Complexity = "Легкий",
                    Movement = "Бёрпи",
                    Modality = "G",
                    Inventory = "Нет",
                    Minutes = "23",
                    Seconds = "20",
                    Exercises = "100 Бёрпи",
                    EmblemHallId = 1
                },
                new Workouts
                {
                    Id = 2,
                    Name = "1000",
                    Rating = "8.5",
                    Category = "Couplet,Bodyweight,For-Time",
                    Complexity = "Сложный",
                    Movement = "Отжимание",
                    Modality = "GM",
                    Inventory = "Скакалка,Ящик для прыжков,Тренажер GHD",
                    Minutes = "50",
                    Seconds = "30",
                    Exercises = "100 Приседания,100 Отжимания,100 Запрыгивание на ящик - 24 / 20 inches,100 Подъемы корпуса на пресс,100 Прыжки на скакалке,100 Отжимания на брусьях,100 Попрыгунчик,100 Ситапы на тренажере GHD,100 Подтягивания",
                    EmblemHallId = 2
                },
                new Workouts
                {
                    Id = 3,
                    Name = "Titan wod",
                    Rating = "10.0",
                    Category = "Couplet,Bodyweight,Rower,ForTime",
                    Complexity = "Нормальный",
                    Movement = "Взятия на грудь",
                    Modality = "GM",
                    Inventory = "Ящик для прыжков",
                    Minutes = "24",
                    Seconds = "00",
                    Exercises = "100 calories Гребля,100 Берпи с перепрыгиванием через ящик,100 seconds Велотренажер",
                    EmblemHallId = 1
                });

            modelBuilder.Entity<Programs>().ToTable("Programs").HasData(
                new Programs
                {
                    Id = 1,
                    Name = "Программа тренировки кроссфит на массу",
                    Rating = "8.0",
                    Description = "Программа тренировок состоит из 38 комплексов с большим преобладанием коротких силовых тренировок и полным отсутствием кардио нагрузки. План тренировок подойдет, если ваша цель - увеличение силы и прирост мышечной масса в ущерб выносливости. План тренировок комбинирует в себе силовые тренировки и короткие “тяжелые” комплексы кроссфит, преобладают базовые упражнения с большими весами на малое кол-во повторов, что является основным условием развития силы и набора массы (мышечной массы) В данной программе встречаются технически сложные тяжелоатлетические упражнения, поэтому обязательно пр...",
                    Type = "Кроссфит",
                    Aim = "Набор мышечной массы",
                    HallId = 1
                },
                new Programs
                {
                    Id = 2,
                    Name = "Plan for the amateur",
                    Description = "План, для аматоров CrossFit План для тренировок в зале с использованием упражнений на силу и выносливость, состоящая в основном из аэробных упражнений, гимнастики (упражнения с весом собственного тела) и тяжёлой атлетики, для людей которые имеют слабую или среднюю базовую подготовку, с целью поддержания и увеличиния физической формы. Если твой уровень выше чем этот то тебе на этот план------> CoachMarchenko",
                    Image = "img/wod.png",
                    Type = "Тяжелая атлетика",
                    Aim = "На силу"
                },
                new Programs
                {
                    Id = 3,
                    Name = "Кроссфит программа тренировок дома без оборудования",
                    Description = "Программа тренировок идеально подойдет для новичков. Большая часть плана состоит из гимнастических тренировок со своим весом и не требует вспомогательных предметов для выполнения. Сами же упражнения очень просты и наверняка давно вам знакомы, поэтому вы можете не обладать специальными знаниями, чтобы заниматься по данному плану. С этой программой вам не нужно обязательно быть в зале во время тренировки, вы можете выполнять тренировки в любом удобном месте.",
                    Type = "Кроссфит",
                    Aim = "Fitness",
                    HallId = 2
                });

            modelBuilder.Entity<ProgramsWorkouts>().ToTable("ProgramsWorkouts").HasData(
                new ProgramsWorkouts
                {
                    Id = 1,
                    ProgramsId = 1,
                    WorkoutsId = 1
                },
                new ProgramsWorkouts
                {
                    Id = 2,
                    ProgramsId = 1,
                    WorkoutsId = 2
                },
                new ProgramsWorkouts
                {
                    Id = 3,
                    ProgramsId = 1,
                    WorkoutsId = 3
                },
                new ProgramsWorkouts
                {
                    Id = 4,
                    ProgramsId = 2,
                    WorkoutsId = 1
                },
                new ProgramsWorkouts
                {
                    Id = 5,
                    ProgramsId = 2,
                    WorkoutsId = 3
                },
                new ProgramsWorkouts
                {
                    Id = 6,
                    ProgramsId = 3,
                    WorkoutsId = 2
                });

            modelBuilder.Entity<User>().ToTable("User").HasData(
                new User
                {
                    Id = 1,
                    Name = "Денис",
                    Surname = "Кудрявов",
                    NickName = "SoEasyBlef",
                    Email = "deniskudravov228@gmail.com",
                    Password = "0000",
                    Country = "Ukraine",
                    Town = "Херсон",
                    Points = 185,
                    Birthday = new DateTime(2003, 08, 23),
                    Height = "185",
                    Weight = "70",
                    AboutMe = "I am a developer C#",
                    GenderId = 1,
                    HallId = null,
                    ProgramsId = null
                });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestsWodCatCloneDb;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public DbSet<Programs> Programs { get; set; }

        public DbSet<Workouts> Workouts { get; set; }

        public DbSet<Exercises> Exercises { get; set; }

        public DbSet<ResultWorkouts> ResultWorkouts { get; set; }

        public DbSet<Halls> Halls { get; set; }

        public DbSet<HallEmblem> HallEmblem { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<ArticlesEmblem> ArticlesEmblem { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Answer> Answer { get; set; }
    }
}
