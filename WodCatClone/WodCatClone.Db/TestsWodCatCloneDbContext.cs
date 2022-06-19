﻿using System;
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
                new HallEmblem { Id = 5, Name = "Banda", Image = "img/EmblemHalls/Banda.png" });

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
                    ArticlesEmblemId = 5
                },
                new Articles
                {
                    Id = 3,
                    Name = "Functional Fitness and CrossFit",
                    Type = "Кроссфит,Бокс",
                    Description = "Functional fitness (using functional movements) is among the most widely spread buzzwords in the gym industry today, but for logical reason. Functional fitness focuses on body training and preparing your body to handle real life scenarios. Functional Movement: Making the muscles work together Body balance & control",
                    FullDescription = "Functional fitness (using functional movements) is among the most widely spread buzzwords in the gym industry today, but for logical reason. Functional fitness focuses on body training and preparing your body to handle real life scenarios.The difference between ordinary gym and functional fitness seems minor to many people but it’s actually huge. Functional fitness builds your body capability for carrying out real life activities in real time, unlike ordinary gymming where you just lift a specific weight in an idealized position, sometimes even formed by a gym machine. There’s a shift of focus from traditional and obsolete ways of body strengthening fitness to novel and more effective ways of achieving functional fitness and CrossFit is surely one of the great options available. Being fit is not the only objective of CrossFit, rather being healthy, strong and lean are the ultimate goals.CrossFit as a leading training system of athletes is known for designing and delivering the most comprehensive and high yielding fitness programs around, catering to all age groups and ability levels. With CrossFit, you will find a lot of true success stories and amazing transformations people have gone through. Functional Movement: Making the muscles work together Traditional weight training isolates muscle groups together but it doesn’t train some of the isolated groups with the others.The key to a successful functional exercise lies in integration, focusing all the muscles to work together instead of isolating them to function independently.Here’s an example of what you might consider a functional exercise: Consider a bent - over row; not the type of row you usually carry out on a seated machine, rather one that you do while leaning over a bench, having weight in one hand with arm hanging straight down, and then pulling the weight up to the extent your elbow points towards the ceiling, ending with your upper arm being parallel to the ground. This is the kind of exercise that builds your back, arms, and shoulder muscles, and due to its nature, it would really work for the entire body.Some of the foundation movements of CrossFit include air squats, front squats, shoulder press, deadlift, press push, push jerk etc."
                    + "CrossFit has designed its workouts on similar ideas that are comprised of functional movements, which also keep on changing.These include pulling, pushing, running, lifting and squatting. Many of these functional movements are executed at a high intensity.Instead of using machines like treadmills etc, CrossFit has equipped itself with kettlebells, pull - up bars, barbells and spacious open space for carrying out running, jumping, squatting, lifting, climbing and throwing.All this is tied together to move your body in the way it should. The CrossFit community has built its exercise methodology on the foundations of weight lifting, gymnastics and endurance / speed / agility - the fundamental components of functional fitness.Body balance & control Most of the people are not even able to control their body weight.They can’t even do a one legged squat without falling over. You can try it now. Can you? As stated by one of the trainers at CrossFit, your first step should be to train your body regarding balancing and controlling its own weight.CrossFit aims to enhance the physical competence of an individual in ten general physical skills. These are defined by CrossFit as:– Cardiovascular / respiratory endurance: It’s the ability of the body to store, process and transmit oxygen.– Stamina: It’s the ability of the body to store, process, transmit and consume energy.– Strength: It’s the ability of a body muscular unit, or group of muscular units, to gain force.– Flexibility: It’s the ability of the body to have maximum motion range at a particular joint.– Power: It’s the ability of a muscular unit, or group of units, to release maximum force in the least time.– Speed: It’s the ability of body to decrease the time cycle of a repeated movement to the least level.– Coordination: It’s the ability of the body to join different movements patterns into a single movement– Agility: It’s the body’s ability to reduce transition time among different movement patterns to least degree.– Balance: It’s the ability to regulate the position of the body’s centre of gravity relative to its support base.– Accuracy: It’s the ability to regulate the movement in a specific direction or at required intensity."
                    + "CrossFit 6221 is more than an excellent centre for functional fitness training.Apart from this incredible program, specialty classes including endurance, mobility and power lifting are also provided to complement your functional fitness and enhance the overall value you are getting.In order to increase the awareness level of people and the community at large regarding the benefits of functional fitness, CrossFit 6221 also conducts special seminars and community events, bringing the people together from different backgrounds to avail strength for facing real life situations.",
                    ArticlesEmblemId = 2
                },
                new Articles
                {
                    Id = 4,
                    Name = "5 Easy Ways to Overcome Doubt",
                    Type = "Кроссфит,Гиревой спорт",
                    Rating = "10.0",
                    Description = "5 простых способов преодолеть сомнения Рядом с целями и мечтами к нам приходят наши «друзья»: сомнения,ужасы и неуверенность в себе.Как заставить себя поверить в собственные силы ? Как не допускать ошибок и двигаться вперед.",
                    FullDescription = "Человеческий мозг всегда ждет подвоха и фокусируется на негативе. Ему значительно проще запомнить твои провалы, чем успехи. Именно поэтому ему необходимо периодически напоминать о том, что вообще за спиной у тебя есть неплохие результаты. Сомневаются в себе все. Даже суперзвезда гольфа Тайгер Вуд признается, что перед важными соревнованиями чувствует неуверенность в себе. Но у него есть секретный прием: «Каждый раз перед важным ударом я делаю глубокий вдох и говорю себе:« Я делал это уже тысячу раз ». Это помогает мне вспомнить, что у меня получалось всегда - а значит, получится и сейчас ». Еще один хороший способ - это действовать очень быстро, чтобы сомнения не успели появиться. Так работает Стивен Кинг, он говорит: «Когда меня одолевают сомнения, мне помогает такая штука: я сажусь и начинаю писать максимально быстро, как только могу. Я записываю все подряд, не раздумывая над тем, хорошо получается или плохо. Так мне удается сохранить первоначальный энтузиазм и одновременно уйти от сомнений в себе » Если ты готовишься к какой-то глобальной события - например выступления с презентацией проекту, - тебе нужно максимально снизить внутреннюю важность этого события. Самый простой способ сделать это - вспомнить, что ты классный не только в работе, но и в других сферах. Ты должен убедить себя, что на этой презентации свет клином не сошелся и не произойдет ничего страшного. Часто хороший сон помогает справиться с неуверенностью в себе. Генеральный директор канадской студии по производству анимационных фильмов Amberwood Entertainment Шелдон Уайзмен говорит: «Когда я начинаю сомневаться в себе, я стараюсь быстрее лечь спать. Для меня сомнения - это, в первую очередь, отсутствие энергии на активные действия. Когда ничего не делаешь, начинаешь сомневаться. Так что лучший способ стать увереннее - лечь спать. Когда просыпаешься утром свеженький, ты готов сделать что угодно!",
                    ArticlesEmblemId = 3
                },
                new Articles
                {
                    Id = 5,
                    Name = "How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?",
                    Type = "Кроссфит,Лёгкая атлетика",
                    Rating = "9.0",
                    Description = "How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?",
                    FullDescription = "How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test? Armando Nava Jr. (a.k.a NavaTheBeast) served in the U.S.Marines for four years before taking to YouTube to vlog about life after the military.While he’s not training with SWAT teams and teaching powerlifters how to crush the brutal Marine Corps.physical fitness test, Nava can be found demonstrating the extensive lessons he learned from the Marines while putting his body through hell. In a recent video, Nava brought his friend and fellow veteran, Marcus Perez in front of the camera to see if they could both take on the famously grueling U.S.Navy SEALs Physical Fitness Test(PFT). Nava's version of the test wasn't exactly what you'd have to take on if you were trying to be a SEAL yourself—the standard test calls for a 500 yard swim in 12 minutes, 30 seconds, 50 pushups in 2 minutes, at least 50 curlups (situps) in 2 minutes, at least 10 pullups in 2 minutes, and a 1.5 mile run in at least 10 minutes and 30 seconds. Nava and Perez flip the order and do the run first, then skip the curlups entirely. Since they're not planning to enlist, we'll cut them some slack. The first portion of the test is a 1.5 mile run, which Nava knocks out in 10 minutes and eight seconds—about 6:39 per mile. Perez’ time is considerably slower but finishes in just under 17 minutes. “I haven’t run in a minute,” says an out of breath Nava, but this is a good start.” With Marcus running in the background, Nava reminds his audience to use his video for inspiration as what he’s doing is “easy to watch, but hard to do.” Next up: pushups.Navy SEALs need to do at least 98 reps to qualify for the Optimum distinction; Nava and Perez are aiming for 100.The guys hammer away at the 100 - pushup goal, sweating through the pain as Nava narrates. “The only way you’re gonna get better is by putting yourself through that pain and that suffering, because that’s what’s going to mold you and that’s what’s going to make you a stronger individual.” "
                    + "Seventy pushups in, Nava is unable to continue and taps out of the challenge, while Marcus just makes it to 100.As the guys rise from the floor, physically shaking, they head inside to handle the next portion of the fitness test: pullups. Nava and Marcus only have to make it to 15 to meet the Optimum requirement, but they aim for 20.After each hitting the target reps, Marcus and Nava head out to conquer the very last challenge: a 500 - meter swim. “We pushing through this pain,” says Nava as he prepares to swim 10 laps, “and so should you.Let’s go finish this test.” The guys absolutely go beast - mode during the final swim, clocking in at eight minutes and five seconds. “I’m sore and hungry,” says Marcus, “I’m just glad I attempted it.” As the video wraps, Nava once again tells viewers to not only watch his videos but go out and actually do what he’s doing yourself. After a 1.5 mile run, pushups, pullups, and a swim, Nava showcases the physical toll the body goes through to make the cut for the elite branches of the military.",
                    ArticlesEmblemId = 4
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
                },
                new Exercises
                {
                    Id = 4,
                    Name = "Бёрпи",
                    Description = "Бурпи – это комплексное упражнение которое используется не только в Кроссфит но и во многих других видах спорта где необходимо развивать и силу и выносливость. А это упражнение предназначено именно для этих целей. Бурпи состоит из трех отдельных упражнений соединенных воедино, а именно из: воздушных приседаний, отжиманий и выпрыгиваний.",
                    FullDescription = "Бурпи – это комплексное упражнение которое используется не только в Кроссфит но и во многих других видах спорта где необходимо развивать и силу и выносливость.А это упражнение предназначено именно для этих целей.Бурпи состоит из трех отдельных упражнений соединенных воедино, а именно из: воздушных приседаний, отжиманий и выпрыгиваний. Исходное положение: -Тело стоит вертикально, ноги на ширине плеч. Выполнение упражнения: -Быстрое опускание в упор лежа - Упор лёжа, отжаться от пола, резко подтянуть колени к груди приняв положение приседа и руки касаются ладонями пола."
                    + "- Выпрыгнуть вверх, сделав лёгкий хлопок руками над головой. - Вернуться в начальное положение. Как вариант можно - вместо прыжка вверх, выполнить прыжок вперёд, отталкиваясь от пола двумя ногами одновременно. Особенности: Бодибилдинг / фитнес: -Отжимания могут быть как до касания грудью пола, так и без касания. CROSSFIT: -Отжимания могут выполняться как «чистыми», так и в технике «лодка». Касание грудью и бедрами пола обязательно. - В верхней точке все тело должно находиться в вертикальном положении, а хлопок выполняться над или за головой."
                    + "Рекомендации: -После отжимания, выполняя прыжок ногами к груди, ставьте стопы на ширине таза или шире.Это позволит сократить амплитуду движения и уменьшить нагрузку на коленные суставы. Противопоказания: С осторожностью выполнять при заболеваниях или травмах поясничного отдела позвоночника.",
                    Complexity = "Легкий",
                    Movement = "Бёрпи",
                    Modality = "G",
                    Inventory = "Нет",
                    Image = "https://www.youtube.com/embed/TU8QYVW0gDU"
                },
                new Exercises
                {
                    Id = 5,
                    Name = "Отжимания",
                    Description = "Отжимания от пола - отличное упражнение для развития мышц груди, плечей и рук как в тренировках в зале так и в домашних тренировках. Существует много видов отжиманий, (отжимания на одной руке, отжимания с узкой постановкой ладоней диамантовые отжимания, отжимания с высокой постановкой ног ) каждый их них по своему уникальный, и все их обязательно стоит научиться делать. Но в КроссФите самые популярные классические отжимания от пола  - которые используются как в отдельных тренировках так и в целых тренировочных комплексах для лучшего эффекта.",
                    FullDescription = "Исходное положение: - Займите упор лежа на прямых руках - Ноги держите вместе - Тело держите максимально параллельно полу, без прогиба в пояснице. Выполнение упражнения: -Начните опускать ваше тело удерживая спину прямой, пока ваша грудь не коснется пола. - Сделайте небольшую паузу и выжмите тело обратно в исходное положение.",
                    Complexity = "Легкий",
                    Movement = "Отжимания",
                    Modality = "G",
                    Inventory = "Нет",
                    Image = "https://www.youtube.com/embed/_l3ySVKYVJ8"
                },
                new Exercises
                {
                    Id = 6,
                    Name = "Запрыгивание на ящик",
                    Description = "Запрыгивания на ящик отлично помогают развить взрывную силу ног. В свою очередь это способствует увеличению результатов в приседаниях со штангой, становой тяге, рывке и толчке штанги. Кроме того выполняя это упражнение  в высоком темпе, оно служит хорошей аэробной нагрузкой для Вашего организма.",
                    FullDescription = "Исходное положение: - Встаньте перед нужным Вам ящиком.Положение ног на ширине плеч. Выполнение упражнения: -Опуститесь в положение полуприседа, и затем с помощью маха руками сделайте сильный прыжок на ящик. - На ящик необходимо приземлятся на чуть присогнутые ноги, это снизит риск получения травмы во время выполнения упражнения.В верхней точке необходимо выпрямить коленные суставы и тазобедренные. - Вы можете прыгнуть обратно в начальное положение, либо спустится вниз по одной ноге. Противопоказания: С осторожностью выполнять упражнение при заболеваниях или травмах коленных суставов и позвоночника, при гипертонии и ВСД.",
                    Complexity = "Легкий",
                    Movement = "Прыжки",
                    Modality = "G",
                    Inventory = "Ящик для прыжков",
                    Image = "https://www.youtube.com/embed/52r_Ul5k03g"
                },
                new Exercises
                {
                    Id = 7,
                    Name = "Подъемы корпуса на пресс",
                    Description = "Ситапы - популярное упражнение среди кроссфитеров, оно является одним из основных упражнений для развития пресса в кроссфите. Техника выполнения ситапов позволяет выдерживать высокую интенсивность нагрузки, что в свою очередь оказывает жиросжигающий эффект.",
                    FullDescription = "Исходное положение: - Лягте на пол или на коврик для упражнений. - Согните ноги в коленях и разведите в разные стороны. - Положите руки на затылок, а локти направьте в стороны. Выполнение упражнения: -Резко поднимите туловище, помогая делая мах руками.При подъеме коснитесь руками ступней ног, а при опускании коснитесь пола за головой. При высокой интенсивности выполнения упражнения, подложите полотенце под поясничный отдел,это позволит сократить рис возникновения травмы позвоночного отдела.",
                    Complexity = "Легкий",
                    Movement = "Пресс",
                    Modality = "G",
                    Inventory = "Нет",
                    Image = "https://www.youtube.com/embed/_HDZODOx7Zw"
                },
                new Exercises
                {
                    Id = 8,
                    Name = "Прыжки на скакалке",
                    Description = "Прыжки на скакалке - это хорошая кардио тренировка, которая не уступает по своим характеристикам бегу или плаванию. За 15 минут тренировки со скакалкой можно сжечь до 200 ккал, при условии постоянной нагрузки.В кроссфите чаще всего пользуются популярностью двойные прыжки на скакалке, выполнение которых потребует от Вас определенных навыков, для такого рода прыжков лучше всего использовать специальные скоростные скакалки на подшипниках.",
                    FullDescription = "Чтобы научится правильно прыгать на скакалке, необходимо как можно больше практиковаться! Учитесь до тех пор пока ваши движения не станут синхронными и отлаженными. Прыгайте на носках, приземляясь на подушечки пальцев, не приземляйтесь на полную стопу. Соблюдайте амплитуду прыжка около 25 см. Скакалку необходимо вращать только при помощи рук.",
                    Complexity = "Легкий",
                    Movement = "Прыжки на скакалке",
                    Modality = "M",
                    Inventory = "Скакалка",
                    Image = "https://www.youtube.com/embed/hCuXYrTOMxI"
                },
                new Exercises
                {
                    Id = 9,
                    Name = "Отжимания на брусьях",
                    Description = "Отжимания на брусьях – одно из лучших базовых многосуставных упражнений, для развития мышц груди, плеч и трицепсов. Отлично подходит как для новичков так и для опытных атлетов. Если вы уверенно отжимаетесь более 20 - и раз, самое время повысить сложность выполнения  упражнения и воспользоваться дополнительным отягощением.",
                    FullDescription = "Отжимания на брусьях – одно из лучших базовых многосуставных упражнений, для развития мышц груди, плеч и трицепсов. Отлично подходит как для новичков так и для опытных атлетов. Если вы уверенно отжимаетесь более 20 - и раз, самое время повысить сложность выполнения  упражнения и воспользоваться дополнительным отягощением. Исходное положение: -Примите положение упора на брусьях на прямых руках. - Начинать это упражнение из нижней позиции весьма рискованно.Старт из верхней точки позволяет мышцам сократиться и приготовиться к работе. Выполнение упражнения: -Наклоните торс вперед, а затем медленно опуститесь между брусьями, сгибая руки в локтях.Важно сопротивляться гравитации на пути вниз, в противном случае, вы можете повредить грудную мышцу. - Достигнув растянутой позиции в нижней точке, поднимайтесь медленно и ровно, выпрямляя локти. Если вам сложно выполнять классические отжимания на брусьях, попробуйте сделать негативные отжимания.Поднимитесь в верхнюю позицию при помощи ног, и сделайте подконтрольное опускание, как можно больше сопротивляясь гравитации.Затем опять с помощью ног встаньте в начальную позицию и повторяйте до тех пор, пока не будет сил делать медленные опускания.Такие отжимания служат хорошей базой для классических отжиманий на брусьях. Особенности: Бодибилдинг / фитнес: Существуют два варианта отжиманий на брусьях. Первый – при опускании вниз локти направлены назад, а корпус наклонен вперед.Такой вид отжиманий акцентированно нагружает трехглавую мышцу плеча.При подъеме необходимо концентрироваться на разгибании рук за счет трехглавой мышцы плеча. Второй – при опускании вниз локти направлены в стороны, и корпус вертикален.Такой вариант способствует смещению нагрузки на грудные мышцы. Противопоказания: Травмы и хронические заболевания плечевого сустава.",
                    Complexity = "Легкий",
                    Movement = "Брусья",
                    Modality = "G",
                    Inventory = "Нет",
                    Image = "https://www.youtube.com/embed/eERwCQHZqfA"
                },
                new Exercises
                {
                    Id = 10,
                    Name = "Попрыгунчик",
                    Description = "Если вы ищете отличное аэробное упражнение которое можно выполнять где угодно, будь вы дома, в отпуске, или на работе. Попрыгунчик это именно то что вам нужно - даже 5 минут выполняя попрыгунчик вы приведете все тело в тонус, разгоните кровь, и получите заряд бодрости и позитива на пару часов!",
                    FullDescription = "Исходное положение: - Встаньте в стойку, ноги на ширине плеч, руки опущены по швам Выполнение упражнения: -Подпрыгните, одновременно расставив ноги и руки в стороны - Приземлитесь, в положении ноги несколько расставлены шире плеч руки направленны в стороны - Подпрыгните из этого положения и примите исходное положение",
                    Complexity = "Легкий",
                    Movement = "Прыжки",
                    Modality = "M",
                    Inventory = "Нет",
                    Image = "https://www.youtube.com/embed/c4DAnQ6DtF8"
                },
                new Exercises
                {
                    Id = 11,
                    Name = "Ситапы на тренажере GHD",
                    Description = "Ситапы на тренажере GHD - ситапы на тренажере GHD немного отличаются от классического выполнения Sit-Up на полу. GHD тренажер, позволяет выполнять упражнение с большей амплитудой и большей скоростью, что несет за собой повышение эффективности упражнения, так как в работу включаются большее количество мышц, и резко повышается энергозатратность упражнения по сравнению с классическими Sit-Up.",
                    FullDescription = "Исходное положение: - Сядьте на GHD, ноги закрепите в подставках для ног таким образом чтоб ягодицы чуть свисали с подушек. - Держите колени согнутыми Выполнение упражнения: -Опустите себя назад, держа спину прямой а колени согнутыми - Опускайте себя как можно ниже пока можете держать спину прямой, без излишнего изгиба - Как только вы достигните крайнего положения начните возвращаться в исходное положение",
                    Complexity = "Нормальный",
                    Movement = "Пресс",
                    Modality = "G",
                    Inventory = "Тренажер GHD",
                    Image = "https://www.youtube.com/embed/1pbZ8mX2D1U"
                },
                new Exercises
                {
                    Id = 12,
                    Name = "Подтягивания",
                    Description = "Подтягивания - это одно из базовых упражнений не только в КроссФите, но и в спорте в целом, почти каждый спортсмен должен уметь выполнять подтягивания. Они помогают развить не только силу мышц спины и рук, но так же помогают обзавестись красивым торсом с использованием всего лишь одного снаряда!",
                    FullDescription = "Исходное положение: - Повисните на перекладине, охватившись за нее ладонями передним хватом(ладони смотрят от вас) Выполнение упражнения: -Начните подтягиваться до тех пор, пока ваш подбородок не окажется выше перекладины. - Сделайте паузу на секунду и опуститесь в исходное положение.Если Вы не можете подтянуться ни разу, начните осваивать подводящие упражнения. - Прыгающие подтягивания: Найдите низкую перекладину, возьмитесь за нее ладонями, подпрыгните пока ваш подбородок не окажется выше перекладины и попытайтесь задержаться на 3 - 4 секунды.Выполняйте это упражнение, до тех пор пока вам не станет легко выполнять 10 - 15 повторений с паузами в 3 - 4 секунды. - Негативные подтягивания: Держась за перекладину подпрыгните, задержавшись в верхнем положении и начните медленно опускаться.Опускание должно занимать около 5 - и секунд.Тренируйте негативные подтягивания пока не почувствуете что вам легко делать 10 повторений. - Подтягивания с облегчением Прикрепите на перекладине резинку и свесьте один конец вниз.Расположите резину по центру перекладины.Возьмитесь за перекладину двумя руками и одной из ног зацепитесь за резину таким образом чтоб она натянулась.Начните подтягиваться, используя натяжение резины.С каждой новой тренировкой используйте все меньшее и меньшее натяжение резины.",
                    Complexity = "Легкий",
                    Movement = "Подтягивание",
                    Modality = "G",
                    Inventory = "Кроссфит стойка",
                    Image = "https://www.youtube.com/embed/r45xLlH7r_M"
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
                    HallId = 1
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
                    HallId = 4
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
                    HallId = 1
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

            modelBuilder.Entity<WorkoutsExercises>().ToTable("WorkoutsExercises").HasData(
                new WorkoutsExercises
                {
                    Id = 1,
                    WorkoutsId = 1,
                    ExercisesId = 4,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 2,
                    WorkoutsId = 2,
                    ExercisesId = 2,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 3,
                    WorkoutsId = 2,
                    ExercisesId = 3,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 4,
                    WorkoutsId = 2,
                    ExercisesId = 5,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 5,
                    WorkoutsId = 2,
                    ExercisesId = 5,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 6,
                    WorkoutsId = 2,
                    ExercisesId = 6,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 7,
                    WorkoutsId = 2,
                    ExercisesId = 7,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 8,
                    WorkoutsId = 2,
                    ExercisesId = 8,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 9,
                    WorkoutsId = 2,
                    ExercisesId = 9,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 10,
                    WorkoutsId = 2,
                    ExercisesId = 10,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 11,
                    WorkoutsId = 2,
                    ExercisesId = 11,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 12,
                    WorkoutsId = 2,
                    ExercisesId = 12,
                    CountRepeats = 100
                },
                new WorkoutsExercises
                {
                    Id = 13,
                    WorkoutsId = 3,
                    ExercisesId = 1,
                },
                new WorkoutsExercises
                {
                    Id = 14,
                    WorkoutsId = 3,
                    ExercisesId = 7,
                    CountRepeats = 50
                },
                new WorkoutsExercises
                {
                    Id = 15,
                    WorkoutsId = 3,
                    ExercisesId = 11,
                    CountRepeats = 50
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
                    GenderId = 1
                });

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestsWodCatCloneDb;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public DbSet<WorkoutsExercises> WorkoutsExercises { get; set; }

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
