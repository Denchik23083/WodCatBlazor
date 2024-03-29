﻿using Moq;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.WebDb.ActionsRepository.ExercisesRepository;
using Xunit;

namespace WodCatClone.Tests.ActionsTests.ExercisesTests
{
    public class ExercisesTests
    {
        private readonly Mock<IExercisesRepository> _repository;

        public ExercisesTests()
        {
            _repository = new Mock<IExercisesRepository>();
        }

        [Fact]
        public async Task GetAllExercises()
        {
            var exercises = new List<Exercises>
            {
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                new()
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
                }
            };

            _repository.Setup(_ => _.GetAllExercisesAsync())
                .ReturnsAsync(exercises);

            IExercisesService service = new ExercisesService(_repository.Object);

            var result = await service.GetAllExercisesAsync();

            _repository.Verify(_ => _.GetAllExercisesAsync(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(exercises.Count, result.Count());
        }

        [Fact]
        public async Task GetExercise()
        {
            var expectedId = 7;

            var exercise = new Exercises
            {
                Id = expectedId,
                Name = "Подъемы корпуса на пресс",
                Description = "Ситапы - популярное упражнение среди кроссфитеров, оно является одним из основных упражнений для развития пресса в кроссфите. Техника выполнения ситапов позволяет выдерживать высокую интенсивность нагрузки, что в свою очередь оказывает жиросжигающий эффект.",
                FullDescription = "Исходное положение: - Лягте на пол или на коврик для упражнений. - Согните ноги в коленях и разведите в разные стороны. - Положите руки на затылок, а локти направьте в стороны. Выполнение упражнения: -Резко поднимите туловище, помогая делая мах руками.При подъеме коснитесь руками ступней ног, а при опускании коснитесь пола за головой. При высокой интенсивности выполнения упражнения, подложите полотенце под поясничный отдел,это позволит сократить рис возникновения травмы позвоночного отдела.",
                Complexity = "Легкий",
                Movement = "Пресс",
                Modality = "G",
                Inventory = "Нет",
                Image = "https://www.youtube.com/embed/_HDZODOx7Zw"
            };

            _repository.Setup(_ => _.GetExerciseAsync(expectedId))
                .ReturnsAsync(exercise);

            IExercisesService service = new ExercisesService(_repository.Object);

            var result = await service.GetExerciseAsync(expectedId);

            _repository.Verify(_ => _.GetExerciseAsync(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedId, result!.Id);
        }
    }
}
