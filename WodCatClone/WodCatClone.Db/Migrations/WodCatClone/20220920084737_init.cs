using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WodCatClone.Db.Migrations.WodCatClone
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleEmblem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleEmblem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventEmblem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEmblem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complexity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Movement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inventory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HallEmblem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallEmblem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramEmblem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramEmblem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleEmblemId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleEmblem_ArticleEmblemId",
                        column: x => x.ArticleEmblemId,
                        principalTable: "ArticleEmblem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeSport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventsEmblemId = table.Column<int>(type: "int", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: true),
                    WorkoutId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventEmblem_EventsEmblemId",
                        column: x => x.EventsEmblemId,
                        principalTable: "EventEmblem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTimeUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTimeUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTimeUser_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Town = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    HallId = table.Column<int>(type: "int", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmblemHallId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Halls_HallEmblem_EmblemHallId",
                        column: x => x.EmblemHallId,
                        principalTable: "HallEmblem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Halls_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramsEmblemId = table.Column<int>(type: "int", nullable: true),
                    HallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programs_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Programs_ProgramEmblem_ProgramsEmblemId",
                        column: x => x.ProgramsEmblemId,
                        principalTable: "ProgramEmblem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complexity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramTimeUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginProgramDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgramsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramTimeUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramTimeUser_Programs_ProgramsId",
                        column: x => x.ProgramsId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramTimeUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramsWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramsId = table.Column<int>(type: "int", nullable: false),
                    WorkoutsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramsWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramsWorkouts_Programs_ProgramsId",
                        column: x => x.ProgramsId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramsWorkouts_Workouts_WorkoutsId",
                        column: x => x.WorkoutsId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<int>(type: "int", nullable: false),
                    Fascination = table.Column<int>(type: "int", nullable: false),
                    Load = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultWorkouts_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResultWorkouts_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutsExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Work = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutsId = table.Column<int>(type: "int", nullable: false),
                    ExercisesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutsExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutsExercises_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutsExercises_Workouts_WorkoutsId",
                        column: x => x.WorkoutsId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Регистрируйтесь на мероприятие, потом проходите задание и вводите ваше время. Лучшие 3 участника получат баллы" },
                    { 8, "Каждый день будет переключаться на следующую тренировку, пока тренировки в этой программе не закончатся. После вам добавят 50 очков" },
                    { 7, "Да" },
                    { 6, "Зайти на тренировку и нажать старт и еще раз старт" },
                    { 5, "Только те, которые создал" },
                    { 4, "Зарабатывать баллы" },
                    { 3, "Баллы дают за создание нового зала, новой статьи, добавление результата о тренировке, за прохождении программы и мероприятия" },
                    { 2, "Зайти в залы и присоединиться" },
                    { 1, "Зарегистрироваться и заполнить форму" },
                    { 9, "Нет" }
                });

            migrationBuilder.InsertData(
                table: "ArticleEmblem",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "img/EmblemArticles/buildhome.png", "Buildhome" },
                    { 2, "img/EmblemArticles/Functional.png", "Functional" },
                    { 3, "img/EmblemArticles/OvercomeDoubt.png", "OvercomeDoubt" },
                    { 4, "img/EmblemArticles/TwoMen.png", "TwoMen" },
                    { 5, "img/EmblemArticles/provides.png", "Provides" }
                });

            migrationBuilder.InsertData(
                table: "EventEmblem",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "img/EmblemEvents/fon.jpg", "Fon" },
                    { 2, "img/EmblemEvents/idi.jpg", "Idi" },
                    { 3, "img/EmblemEvents/lime.jpg", "Lime" },
                    { 4, "img/EmblemEvents/run.jpg", "Run" },
                    { 5, "img/EmblemEvents/sport.jpg", "Sport" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Complexity", "Description", "FullDescription", "Image", "Inventory", "Modality", "Movement", "Name" },
                values: new object[,]
                {
                    { 2, "Нормальный", "Выход на кольцах - упражнение продвинутого уровня в кроссфите. Обычный выход на кольцах  или же (киппинг выход на кольцах), немного легче, нежели строгий вариант выходов, хотя он требует не меньших усилий в изучении. Перед тем как приступать к изучению выходов на кольцах, желательно уметь подтягиваться в строгом стиле на кольцах минимум 15 раз и уметь отжиматься на кольцах 15-20 раз, тогда вы можете быть уверены, что ваши мышцы вас не подведут.Помните,что выходы на кольцах это больше техническое,нежели силовое упражнение и чаще всего упражнение может не получатся из за нехватки опыта и техники,нежели сил! ", "Техника выполнения упражнения: <<Выход на кольцах>>Исходное положение:-Повисните на вытянутых руках,на кольцах- Хват обычныйВыполнение упражнения:-Сделайте несколько махов телом в положении виса на кольцах- Затем сделайте достаточно сильных замах назад,выгнувшись в спине в обратную сторону.- Из положения прогиба сделайте вымах вперед,вылетая таким образом в на уровень колец.По мере приближении тела к кольцам начните разгибать тело в горизонтально ровную позицию,придавая телу инерцию.Тело от такого маха должно оказаться примерно параллельным полу.- Используя полученную энергию,подтяните себя как можно ближе к кольцам,вылетая при этом в положение упора кольцах,не гася при этом инерцию полета.- Если вам не хватило инерции и вы вылетели в положение на согнутых руках в упор,выжмите себя в положение на прямые руки используя силу трицепса и плеч,так же можно придать дополнительный импульс,делая рывок ногами.", "https://www.youtube.com/embed/BQS4Kw7q7OQ", "Кольца гимнастические", "G", "Выход на кольцах", "Выход на кольцах" },
                    { 1, "Легкий", "Бег, равно как и ходьба – абсолютно естественное для организма состояние.Но начинающие бегуны могут столкнуться со множеством проблем.Оказывается,бегать – не так - то просто.Существует даже такое понятие как правильный беговой почерк.Оно подразумевает прямо поставленную голову,ровную спину,правильное расположение ног.Только когда все составляющие выдержаны,можно добиться легкого и быстрого бега.", "Итак, какие аспекты необходимо выдерживать тем, кто стремится овладеть правильной техникой бега:- Свести вертикальные колебания тела к минимуму.Резкие удары о беговую поверхность,равно как и выбрасывания тела в воздух могут привести к сильному возрастанию нагрузки на суставы и позвоночник.- Не допускать раскачиваний тела в разные стороны.Вообще такие раскачивания могут быть,если стопы относительно друг друга стоят неправильно.Потому необходимо учиться бегать так,чтобы внутренние края стоп находились на одной линии.Допускается лишь небольшой угол,который может образовываться между носками стоп.Это позволит при толчке максимальное усилие направить на большой палец.- Правильный бег предусматривает также грамотную постановку ступней,когда они касаются поверхности земли.Специалисты выделяют три метода – вся стопа,носок - пятка и пятка - носок.Начинающие бегуны должны стремиться распределять нагрузку равномерно на всю стопу – это существенно разгрузит суставы.Правильная техника бега позволяет проверить постановку стоп таким образом: нужно провести прямую линию к беговой поверхности через центр тяжести тела.Пройти эта линия должна через центр стопы.Для сравнения,при ходьбе она проходит через пятку.Еще один момент: при касании земли стопу следует слегка напрячь.- Чтобы научиться бегать,следует также правильно подобрать длину шага.Узкий шаг не дает достаточный тонус мышцам.Тогда как чрезмерно широкий шаг увеличивает риск приземления на прямую ногу.- Верхняя часть туловища при правильном беге должна быть неподвижной.Осанку придется выдерживать,то есть не наклоняться вперед и не запрокидывать туловище назад.Все это позволит уберечь от травм суставы и позвоночник.Также следует следить за положением рук.Так,в локтях они должны быть согнуты под прямым углом,кисти должны быть слегка сжатыми.Голову также нельзя наклонять низко взгляд должен быть направлен метров на 10 - 15 вперед.- Правильная техника бега невозможна без непринужденного ритмичного дыхания – это не позволяет организму слишком рано устать.Итак,какие аспекты необходимо выдерживать тем,кто стремится овладеть правильной техникой бега:-Свести вертикальные колебания тела к минимуму.Резкие удары о беговую поверхность,равно как и выбрасывания тела в воздух могут привести к сильному возрастанию нагрузки на суставы и позвоночник.- Не допускать раскачиваний тела в разные стороны.Вообще такие раскачивания могут быть,если стопы относительно друг друга стоят неправильно.Потому необходимо учиться бегать так,чтобы внутренние края стоп находились на одной линии.Допускается лишь небольшой угол,который может образовываться между носками стоп.Это позволит при толчке максимальное усилие направить на большой палец.- Правильный бег предусматривает также грамотную постановку ступней,когда они касаются поверхности земли.Специалисты выделяют три метода – вся стопа,носок - пятка и пятка - носок.Начинающие бегуны должны стремиться распределять нагрузку равномерно на всю стопу – это существенно разгрузит суставы.Правильная техника бега позволяет проверить постановку стоп таким образом: нужно провести прямую линию к беговой поверхности через центр тяжести тела.Пройти эта линия должна через центр стопы.Для сравнения,при ходьбе она проходит через пятку.Еще один момент: при касании земли стопу следует слегка напрячь.- Чтобы научиться бегать,следует также правильно подобрать длину шага.Узкий шаг не дает достаточный тонус мышцам.Тогда как чрезмерно широкий шаг увеличивает риск приземления на прямую ногу.- Верхняя часть туловища при правильном беге должна быть неподвижной.Осанку придется выдерживать,то есть не наклоняться вперед и не запрокидывать туловище назад.Все это позволит уберечь от травм суставы и позвоночник.Также следует следить за положением рук.Так,в локтях они должны быть согнуты под прямым углом,кисти должны быть слегка сжатыми.Голову также нельзя наклонять низко взгляд должен быть направлен метров на 10 - 15 вперед.- Правильная техника бега невозможна без непринужденного ритмичного дыхания – это не позволяет организму слишком рано устать.", "https://www.youtube.com/embed/t7ZD68RKTT8", "Нет", "M", "Бег", "Бег" },
                    { 12, "Легкий", "Подтягивания - это одно из базовых упражнений не только в КроссФите, но и в спорте в целом, почти каждый спортсмен должен уметь выполнять подтягивания. Они помогают развить не только силу мышц спины и рук, но так же помогают обзавестись красивым торсом с использованием всего лишь одного снаряда!", "Исходное положение: - Повисните на перекладине, охватившись за нее ладонями передним хватом(ладони смотрят от вас) Выполнение упражнения: -Начните подтягиваться до тех пор, пока ваш подбородок не окажется выше перекладины. - Сделайте паузу на секунду и опуститесь в исходное положение.Если Вы не можете подтянуться ни разу, начните осваивать подводящие упражнения. - Прыгающие подтягивания: Найдите низкую перекладину, возьмитесь за нее ладонями, подпрыгните пока ваш подбородок не окажется выше перекладины и попытайтесь задержаться на 3 - 4 секунды.Выполняйте это упражнение, до тех пор пока вам не станет легко выполнять 10 - 15 повторений с паузами в 3 - 4 секунды. - Негативные подтягивания: Держась за перекладину подпрыгните, задержавшись в верхнем положении и начните медленно опускаться.Опускание должно занимать около 5 - и секунд.Тренируйте негативные подтягивания пока не почувствуете что вам легко делать 10 повторений. - Подтягивания с облегчением Прикрепите на перекладине резинку и свесьте один конец вниз.Расположите резину по центру перекладины.Возьмитесь за перекладину двумя руками и одной из ног зацепитесь за резину таким образом чтоб она натянулась.Начните подтягиваться, используя натяжение резины.С каждой новой тренировкой используйте все меньшее и меньшее натяжение резины.", "https://www.youtube.com/embed/r45xLlH7r_M", "Кроссфит стойка", "G", "Подтягивание", "Подтягивания" },
                    { 3, "Сложный", "Выбросы со штангой или «Трастеры» - это упражнение, которое одновременно задействует большое количество крупных мышц. Данное упражнение отлично развивает как и силовые показатели так и выносливые, это зависит от того какой вес и диапазон повторений вы будете использовать в своих тренировках.Трастеры – это так же и универсальное упражнение,классический вариант исполнения,это выбросы со штангой,но вы легко можете использовать самое разнообразное оборудование(гири, гантели, мешок с песком, медболы, и т.д.).", "Техника выполнения упражнения: «Выбросы со штангой Thrusters»Исходное положение:-Возьмите штангу в передний упор на груди,так же как в стартовой позиции для фронтальных приседаний.- Спина ровная,положение ступней на ширине плеч.- Локти подняты,взгляд направлен вперед.Выполнение упражнения:-Опуститесь в нижнее положение приседания,со штангой на груди.- Начните мощно вставать и одновременно выжимайте штангу в положение над головой,до тех пор,пока ваши руки не окажутся прямыми.- Зафиксируйте штангу на вытянутых руках,и после небольшой паузы опуститесь обратно в положение приседа,во время опускания так же опустите штангу на грудь.", "https://www.youtube.com/embed/aea5BGj9a8Y", "Штанга", "W", "Выбросы", "Выбросы" },
                    { 4, "Легкий", "Бурпи – это комплексное упражнение которое используется не только в Кроссфит но и во многих других видах спорта где необходимо развивать и силу и выносливость. А это упражнение предназначено именно для этих целей. Бурпи состоит из трех отдельных упражнений соединенных воедино, а именно из: воздушных приседаний, отжиманий и выпрыгиваний.", "Бурпи – это комплексное упражнение которое используется не только в Кроссфит но и во многих других видах спорта где необходимо развивать и силу и выносливость.А это упражнение предназначено именно для этих целей.Бурпи состоит из трех отдельных упражнений соединенных воедино, а именно из: воздушных приседаний, отжиманий и выпрыгиваний. Исходное положение: -Тело стоит вертикально, ноги на ширине плеч. Выполнение упражнения: -Быстрое опускание в упор лежа - Упор лёжа, отжаться от пола, резко подтянуть колени к груди приняв положение приседа и руки касаются ладонями пола.- Выпрыгнуть вверх, сделав лёгкий хлопок руками над головой. - Вернуться в начальное положение. Как вариант можно - вместо прыжка вверх, выполнить прыжок вперёд, отталкиваясь от пола двумя ногами одновременно. Особенности: Бодибилдинг / фитнес: -Отжимания могут быть как до касания грудью пола, так и без касания. CROSSFIT: -Отжимания могут выполняться как «чистыми», так и в технике «лодка». Касание грудью и бедрами пола обязательно. - В верхней точке все тело должно находиться в вертикальном положении, а хлопок выполняться над или за головой.Рекомендации: -После отжимания, выполняя прыжок ногами к груди, ставьте стопы на ширине таза или шире.Это позволит сократить амплитуду движения и уменьшить нагрузку на коленные суставы. Противопоказания: С осторожностью выполнять при заболеваниях или травмах поясничного отдела позвоночника.", "https://www.youtube.com/embed/TU8QYVW0gDU", "Нет", "G", "Бёрпи", "Бёрпи" },
                    { 5, "Легкий", "Отжимания от пола - отличное упражнение для развития мышц груди, плечей и рук как в тренировках в зале так и в домашних тренировках. Существует много видов отжиманий, (отжимания на одной руке, отжимания с узкой постановкой ладоней диамантовые отжимания, отжимания с высокой постановкой ног ) каждый их них по своему уникальный, и все их обязательно стоит научиться делать. Но в КроссФите самые популярные классические отжимания от пола  - которые используются как в отдельных тренировках так и в целых тренировочных комплексах для лучшего эффекта.", "Исходное положение: - Займите упор лежа на прямых руках - Ноги держите вместе - Тело держите максимально параллельно полу, без прогиба в пояснице. Выполнение упражнения: -Начните опускать ваше тело удерживая спину прямой, пока ваша грудь не коснется пола. - Сделайте небольшую паузу и выжмите тело обратно в исходное положение.", "https://www.youtube.com/embed/_l3ySVKYVJ8", "Нет", "G", "Отжимания", "Отжимания" },
                    { 11, "Нормальный", "Ситапы на тренажере GHD - ситапы на тренажере GHD немного отличаются от классического выполнения Sit-Up на полу. GHD тренажер, позволяет выполнять упражнение с большей амплитудой и большей скоростью, что несет за собой повышение эффективности упражнения, так как в работу включаются большее количество мышц, и резко повышается энергозатратность упражнения по сравнению с классическими Sit-Up.", "Исходное положение: - Сядьте на GHD, ноги закрепите в подставках для ног таким образом чтоб ягодицы чуть свисали с подушек. - Держите колени согнутыми Выполнение упражнения: -Опустите себя назад, держа спину прямой а колени согнутыми - Опускайте себя как можно ниже пока можете держать спину прямой, без излишнего изгиба - Как только вы достигните крайнего положения начните возвращаться в исходное положение", "https://www.youtube.com/embed/1pbZ8mX2D1U", "Тренажер GHD", "G", "Пресс", "Ситапы на тренажере GHD" },
                    { 6, "Легкий", "Запрыгивания на ящик отлично помогают развить взрывную силу ног. В свою очередь это способствует увеличению результатов в приседаниях со штангой, становой тяге, рывке и толчке штанги. Кроме того выполняя это упражнение  в высоком темпе, оно служит хорошей аэробной нагрузкой для Вашего организма.", "Исходное положение: - Встаньте перед нужным Вам ящиком.Положение ног на ширине плеч. Выполнение упражнения: -Опуститесь в положение полуприседа, и затем с помощью маха руками сделайте сильный прыжок на ящик. - На ящик необходимо приземлятся на чуть присогнутые ноги, это снизит риск получения травмы во время выполнения упражнения.В верхней точке необходимо выпрямить коленные суставы и тазобедренные. - Вы можете прыгнуть обратно в начальное положение, либо спустится вниз по одной ноге. Противопоказания: С осторожностью выполнять упражнение при заболеваниях или травмах коленных суставов и позвоночника, при гипертонии и ВСД.", "https://www.youtube.com/embed/52r_Ul5k03g", "Ящик для прыжков", "G", "Прыжки", "Запрыгивание на ящик" },
                    { 7, "Легкий", "Ситапы - популярное упражнение среди кроссфитеров, оно является одним из основных упражнений для развития пресса в кроссфите. Техника выполнения ситапов позволяет выдерживать высокую интенсивность нагрузки, что в свою очередь оказывает жиросжигающий эффект.", "Исходное положение: - Лягте на пол или на коврик для упражнений. - Согните ноги в коленях и разведите в разные стороны. - Положите руки на затылок, а локти направьте в стороны. Выполнение упражнения: -Резко поднимите туловище, помогая делая мах руками.При подъеме коснитесь руками ступней ног, а при опускании коснитесь пола за головой. При высокой интенсивности выполнения упражнения, подложите полотенце под поясничный отдел,это позволит сократить рис возникновения травмы позвоночного отдела.", "https://www.youtube.com/embed/_HDZODOx7Zw", "Нет", "G", "Пресс", "Подъемы корпуса на пресс" },
                    { 8, "Легкий", "Прыжки на скакалке - это хорошая кардио тренировка, которая не уступает по своим характеристикам бегу или плаванию. За 15 минут тренировки со скакалкой можно сжечь до 200 ккал, при условии постоянной нагрузки.В кроссфите чаще всего пользуются популярностью двойные прыжки на скакалке, выполнение которых потребует от Вас определенных навыков, для такого рода прыжков лучше всего использовать специальные скоростные скакалки на подшипниках.", "Чтобы научится правильно прыгать на скакалке, необходимо как можно больше практиковаться! Учитесь до тех пор пока ваши движения не станут синхронными и отлаженными. Прыгайте на носках, приземляясь на подушечки пальцев, не приземляйтесь на полную стопу. Соблюдайте амплитуду прыжка около 25 см. Скакалку необходимо вращать только при помощи рук.", "https://www.youtube.com/embed/hCuXYrTOMxI", "Скакалка", "M", "Прыжки на скакалке", "Прыжки на скакалке" },
                    { 9, "Легкий", "Отжимания на брусьях – одно из лучших базовых многосуставных упражнений, для развития мышц груди, плеч и трицепсов. Отлично подходит как для новичков так и для опытных атлетов. Если вы уверенно отжимаетесь более 20 - и раз, самое время повысить сложность выполнения  упражнения и воспользоваться дополнительным отягощением.", "Отжимания на брусьях – одно из лучших базовых многосуставных упражнений, для развития мышц груди, плеч и трицепсов. Отлично подходит как для новичков так и для опытных атлетов. Если вы уверенно отжимаетесь более 20 - и раз, самое время повысить сложность выполнения  упражнения и воспользоваться дополнительным отягощением. Исходное положение: -Примите положение упора на брусьях на прямых руках. - Начинать это упражнение из нижней позиции весьма рискованно.Старт из верхней точки позволяет мышцам сократиться и приготовиться к работе. Выполнение упражнения: -Наклоните торс вперед, а затем медленно опуститесь между брусьями, сгибая руки в локтях.Важно сопротивляться гравитации на пути вниз, в противном случае, вы можете повредить грудную мышцу. - Достигнув растянутой позиции в нижней точке, поднимайтесь медленно и ровно, выпрямляя локти. Если вам сложно выполнять классические отжимания на брусьях, попробуйте сделать негативные отжимания.Поднимитесь в верхнюю позицию при помощи ног, и сделайте подконтрольное опускание, как можно больше сопротивляясь гравитации.Затем опять с помощью ног встаньте в начальную позицию и повторяйте до тех пор, пока не будет сил делать медленные опускания.Такие отжимания служат хорошей базой для классических отжиманий на брусьях. Особенности: Бодибилдинг / фитнес: Существуют два варианта отжиманий на брусьях. Первый – при опускании вниз локти направлены назад, а корпус наклонен вперед.Такой вид отжиманий акцентированно нагружает трехглавую мышцу плеча.При подъеме необходимо концентрироваться на разгибании рук за счет трехглавой мышцы плеча. Второй – при опускании вниз локти направлены в стороны, и корпус вертикален.Такой вариант способствует смещению нагрузки на грудные мышцы. Противопоказания: Травмы и хронические заболевания плечевого сустава.", "https://www.youtube.com/embed/eERwCQHZqfA", "Нет", "G", "Брусья", "Отжимания на брусьях" },
                    { 10, "Легкий", "Если вы ищете отличное аэробное упражнение которое можно выполнять где угодно, будь вы дома, в отпуске, или на работе. Попрыгунчик это именно то что вам нужно - даже 5 минут выполняя попрыгунчик вы приведете все тело в тонус, разгоните кровь, и получите заряд бодрости и позитива на пару часов!", "Исходное положение: - Встаньте в стойку, ноги на ширине плеч, руки опущены по швам Выполнение упражнения: -Подпрыгните, одновременно расставив ноги и руки в стороны - Приземлитесь, в положении ноги несколько расставлены шире плеч руки направленны в стороны - Подпрыгните из этого положения и примите исходное положение", "https://www.youtube.com/embed/c4DAnQ6DtF8", "Нет", "M", "Прыжки", "Попрыгунчик" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 2, "img/woman.png", "Женский" },
                    { 1, "img/man.png", "Мужской" }
                });

            migrationBuilder.InsertData(
                table: "HallEmblem",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 2, "img/EmblemHalls/M4.png", "M4" },
                    { 5, "img/EmblemHalls/Banda.png", "Banda" },
                    { 4, "img/EmblemHalls/BlasArea.png", "BlasArea" },
                    { 3, "img/EmblemHalls/Olimp.png", "Olimp" },
                    { 1, "img/EmblemHalls/Dog.png", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "ProgramEmblem",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 5, "img/EmblemPrograms/Wod.png", "Wod" },
                    { 4, "img/EmblemPrograms/NRC.png", "NRC" },
                    { 3, "img/EmblemPrograms/Men.png", "Men" }
                });

            migrationBuilder.InsertData(
                table: "ProgramEmblem",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[] { 2, "img/EmblemPrograms/GymMan.png", "GymMan" });

            migrationBuilder.InsertData(
                table: "ProgramEmblem",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[] { 1, "img/EmblemPrograms/BallMan.png", "BallMan" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleEmblemId", "Description", "FullDescription", "Name", "Rating", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "A Home Gym You’ll Actually Use Learn from my mistakes &the times I got it right My Home Gym Gear Shopping List for a Garage Gym", "A Home Gym You’ll Actually Use For those new to functional training, such as CrossFit,and looking to build out your own garage gym or home gym and training space,here’s an equipment guide to get you started.My aim is to save you from buying equipment that you’ll rarely use — equipment that wastes your money and takes up valuable space.In this article,I share with you what I setup recently after I sold my CrossFit gym and wanted a place at home to train.Learn from my mistakes &the times I got it right For more than 25 years I’ve been an endurance athlete,half of that time working as a coach,I’ve either had a small gym at home or access to a great gym near home.I also built a full CrossFit gym in Switzerland,ran it for 5 years, and sold it to a great friend and trainer.After selling my gym and spending more time at home writing coaching books, I was desperate to build a home gym once again.In this article, I share with you my recommendations for equipment to buy for home that you will actually use, not one that is ego - driven or based on what looks great in an Instagram post, but is not what you will really use.I’ve purchased a wide range of equipment over the years, spanning a mix of great buying decisions and some terrible choices.I aim to guide you toward building a home gym that you’ll feel great about now, as well as in a few years.I offer my top recommendations, share what I purchased and suggest a super saver option for each item.My Home GymOf all the gyms I’ve setup over the years, this is my favorite home gym.Why ? Because it’s right where it needs to be for me to actually use it and has exactly what I need for my indoors training.I set it up in a small winter garden room.I love this gym — it has everything I want and nothing more.It’s not flashy or showy, yet it can handle the heaviest lifts I’ll ever do, high intensity training, strength training, CrossFit WODs, Hero WODs and more. I carefully selected every piece of equipment.Gear Shopping List for a Garage GymMust - Have EquipmentI’ll start with what I consider must - have gear.Barbell – This is the most important piece of equipment you will have in your arsenal.Training trends come and go, but old school barbell strength training is timeless and extremely effective. Master these 3 movements and you will have 80 % of what you need for strength training to serve your needs for decades: Back Squat, Deadlift, Overhead Press.Grow from there into Power Cleans, Front Squats, and Thrusters.And if you discover a passion for barbell training, you’ll likely find yourself diving into the technique work required for Overhead Squats, Cleans, and Snatch.You get what you pay for, so invest in a quality bar.Check out Rogue’s Ohio Bar as a high quality starter and consider upgrade options from there only if you get very serious about Olympic Lifting.For women or anyone with smaller hands, consider a 25mm version, and for kids, newbie and rehab use, check out this option.I only wanted one barbell for our small training space at home, so I opted for the 15kg Bella Bar, which works perfectly for either of us.Super Saver Option: buy a used bar from a CrossFit gym that is going out of business or when a college or fitness center upgrades equipment.Don’t forget collars – You can get the Rogue Fitness HG collars, Rogue OSU, or a pair of good old spring collars.Squat Stand or Rack – There are many different variation for this important piece of equipment.Rogue has created some very innovative designs recently.I love their Monster Lite Fold Back Racks.If I had the right space for this, it’s exactly what I’d buy.If space is no concern and you want to lift heavy with maximum safety options, then have a look at a Power Rack.The first piece of equipment I bought for my first gym location was a Power Rack R - 3.For my home gym, I wanted flexibility and the option to carry the stands outside, so I opted for the S-4 model.It’s super stable and handles everything I throw at it.Super Saver Option: My very first squat stands were a pair of cheap construction stands from the local home improvement store.They weren’t elegant and not especially stable, but they did the job until I could afford stable, safer stands.Bumper Plates – Invest in bumper plates and you won’t regret it for home use, especially if you get more into Olympic weightlifting movements. Buy the max weight you’ll realistically need and add weight if and when the time comes. I have 120kg / 265lbs of weights, as I don’t expect to ever need more than that for home use and don’t want extra plates taking up space.My favorite bumpers are Rogue HG.If you go cheap on bumpers, they won’t last and you’ll regret it.Super Saver Option: Same as with barbells: going out of business sales, upgrading equipment, etc.Kettlebells: There is some much you can do with power and strength training, as well as conditioning, with kettlebells. That’s what puts them on the must - have list.I recommend starting light, in the 12kg / 25lb range and then working your way up. My go-to kettlebell is a 53lb / 24KG Rogue Competition model. I have only 3 kettlebells in my home gym: 12kg(25lb), 16kg(35lb), and 24kg(55lb).My advice is to buy high quality kettlebells.These are heavy devices and not easy to get rid of.My first few kettlebells have terrible handles and I regret buying them.Super Saver Option: Same as with barbells and bumper plates. You may more easily find cheap used dumbbells, so start there if no cheap kettlebell options exist in your area.Important Items NOT on the Must Have ListI left off some important training equipment intentionally, as a tight budget means making tough choices. For example, a Bench is on the Nice - to - Have list.You can do floor press instead of bench press and standing overhead press instead of a seated press and wait until you’ve go the cash for a bench. Same goes for pull - ups(you can do pull - ups from a barbell placed on your squat stands).Nice - to - Have EquipmentThis list is where I’d spend hard - earned money once the must-haves are in your house.Sandbag: This is a great all - around training tool. It is simple and effective.You can buy them in all sizes and designs these days. If you opt to buy one, make sure the quality is high.I’ve seen too many sandbags bust open in real - world training.Get a good one or make one yourself that will last.Super Saver Option: Here’s a How - to guide on making your own and some suggested sandbag workouts.Bench: simple is good.Simple and strong: even better. I recommend the Rogue Bolt Together Utility Bench. In addition to bench press and seated overhead press, you can also use a bench for core work and box step - ups(if you don’t have a plyo box).Super Saver Option: Pick up a used bench or build a very basic DIY bench yourself.Rings: If I had to choose rings over a pull - up rig, I’d choose rings any day.You can hang rings from the ceiling, from trees and other features outside, and from a barbell placed on your squat stands or rack. You can do most of the fundamental TRX movements with rings, as well as pull - ups and dips. I love classic wooden gymnastics rings. I drilled into the thick concrete ceiling of my balcony to mount my rings. Sure, get a TRX too, but make sure you’ve got rings in the gym first.Pull - up Rig: If you’ve got a place for it, then go for it.Use bands to scale the movement so that you can perform it with proper form while building strength.You can mount a pull - up bar on the wall or ceiling, use a portable system that you can hang from various things or go with a doorway option.Jump Rope: Simple, portable, great for metabolic conditioning (try 5 rounds of 90sec rope skipping + 10 burpees + 10 sit - ups for a great little workout).I have a collection of ropes for different workout types, including a custom RX, a Rogue SR - 3, and a Rogue Heavy Rope.AbMat: Lots of improvements since the first generation of these great little pieces of equipment.I have a first gen AbMat, as well as a new Wise Crack — which I’ve tested on Annie and highly endorse if you’ve ever dealt with a case of CrossFit sit - up butt rub!", "Build a Home Gym in 2020 That You Will Actually Use", null, "Кроссфит,Статьи", null },
                    { 3, 2, "Functional fitness (using functional movements) is among the most widely spread buzzwords in the gym industry today, but for logical reason. Functional fitness focuses on body training and preparing your body to handle real life scenarios. Functional Movement: Making the muscles work together Body balance & control", "Functional fitness (using functional movements) is among the most widely spread buzzwords in the gym industry today, but for logical reason. Functional fitness focuses on body training and preparing your body to handle real life scenarios.The difference between ordinary gym and functional fitness seems minor to many people but it’s actually huge. Functional fitness builds your body capability for carrying out real life activities in real time, unlike ordinary gymming where you just lift a specific weight in an idealized position, sometimes even formed by a gym machine. There’s a shift of focus from traditional and obsolete ways of body strengthening fitness to novel and more effective ways of achieving functional fitness and CrossFit is surely one of the great options available. Being fit is not the only objective of CrossFit, rather being healthy, strong and lean are the ultimate goals.CrossFit as a leading training system of athletes is known for designing and delivering the most comprehensive and high yielding fitness programs around, catering to all age groups and ability levels. With CrossFit, you will find a lot of true success stories and amazing transformations people have gone through. Functional Movement: Making the muscles work together Traditional weight training isolates muscle groups together but it doesn’t train some of the isolated groups with the others.The key to a successful functional exercise lies in integration, focusing all the muscles to work together instead of isolating them to function independently.Here’s an example of what you might consider a functional exercise: Consider a bent - over row; not the type of row you usually carry out on a seated machine, rather one that you do while leaning over a bench, having weight in one hand with arm hanging straight down, and then pulling the weight up to the extent your elbow points towards the ceiling, ending with your upper arm being parallel to the ground. This is the kind of exercise that builds your back, arms, and shoulder muscles, and due to its nature, it would really work for the entire body.Some of the foundation movements of CrossFit include air squats, front squats, shoulder press, deadlift, press push, push jerk etc.CrossFit has designed its workouts on similar ideas that are comprised of functional movements, which also keep on changing.These include pulling, pushing, running, lifting and squatting. Many of these functional movements are executed at a high intensity.Instead of using machines like treadmills etc, CrossFit has equipped itself with kettlebells, pull - up bars, barbells and spacious open space for carrying out running, jumping, squatting, lifting, climbing and throwing.All this is tied together to move your body in the way it should. The CrossFit community has built its exercise methodology on the foundations of weight lifting, gymnastics and endurance / speed / agility - the fundamental components of functional fitness.Body balance & control Most of the people are not even able to control their body weight.They can’t even do a one legged squat without falling over. You can try it now. Can you? As stated by one of the trainers at CrossFit, your first step should be to train your body regarding balancing and controlling its own weight.CrossFit aims to enhance the physical competence of an individual in ten general physical skills. These are defined by CrossFit as:– Cardiovascular / respiratory endurance: It’s the ability of the body to store, process and transmit oxygen.– Stamina: It’s the ability of the body to store, process, transmit and consume energy.– Strength: It’s the ability of a body muscular unit, or group of muscular units, to gain force.– Flexibility: It’s the ability of the body to have maximum motion range at a particular joint.– Power: It’s the ability of a muscular unit, or group of units, to release maximum force in the least time.– Speed: It’s the ability of body to decrease the time cycle of a repeated movement to the least level.– Coordination: It’s the ability of the body to join different movements patterns into a single movement– Agility: It’s the body’s ability to reduce transition time among different movement patterns to least degree.– Balance: It’s the ability to regulate the position of the body’s centre of gravity relative to its support base.– Accuracy: It’s the ability to regulate the movement in a specific direction or at required intensity.CrossFit 6221 is more than an excellent centre for functional fitness training.Apart from this incredible program, specialty classes including endurance, mobility and power lifting are also provided to complement your functional fitness and enhance the overall value you are getting.In order to increase the awareness level of people and the community at large regarding the benefits of functional fitness, CrossFit 6221 also conducts special seminars and community events, bringing the people together from different backgrounds to avail strength for facing real life situations.", "Functional Fitness and CrossFit", null, "Кроссфит,Бокс", null },
                    { 4, 3, "5 простых способов преодолеть сомнения Рядом с целями и мечтами к нам приходят наши «друзья»: сомнения,ужасы и неуверенность в себе.Как заставить себя поверить в собственные силы ? Как не допускать ошибок и двигаться вперед.", "Человеческий мозг всегда ждет подвоха и фокусируется на негативе. Ему значительно проще запомнить твои провалы, чем успехи. Именно поэтому ему необходимо периодически напоминать о том, что вообще за спиной у тебя есть неплохие результаты. Сомневаются в себе все. Даже суперзвезда гольфа Тайгер Вуд признается, что перед важными соревнованиями чувствует неуверенность в себе. Но у него есть секретный прием: «Каждый раз перед важным ударом я делаю глубокий вдох и говорю себе:« Я делал это уже тысячу раз ». Это помогает мне вспомнить, что у меня получалось всегда - а значит, получится и сейчас ». Еще один хороший способ - это действовать очень быстро, чтобы сомнения не успели появиться. Так работает Стивен Кинг, он говорит: «Когда меня одолевают сомнения, мне помогает такая штука: я сажусь и начинаю писать максимально быстро, как только могу. Я записываю все подряд, не раздумывая над тем, хорошо получается или плохо. Так мне удается сохранить первоначальный энтузиазм и одновременно уйти от сомнений в себе » Если ты готовишься к какой-то глобальной события - например выступления с презентацией проекту, - тебе нужно максимально снизить внутреннюю важность этого события. Самый простой способ сделать это - вспомнить, что ты классный не только в работе, но и в других сферах. Ты должен убедить себя, что на этой презентации свет клином не сошелся и не произойдет ничего страшного. Часто хороший сон помогает справиться с неуверенностью в себе. Генеральный директор канадской студии по производству анимационных фильмов Amberwood Entertainment Шелдон Уайзмен говорит: «Когда я начинаю сомневаться в себе, я стараюсь быстрее лечь спать. Для меня сомнения - это, в первую очередь, отсутствие энергии на активные действия. Когда ничего не делаешь, начинаешь сомневаться. Так что лучший способ стать увереннее - лечь спать. Когда просыпаешься утром свеженький, ты готов сделать что угодно!", "5 Easy Ways to Overcome Doubt", "10.0", "Кроссфит,Гиревой спорт", null },
                    { 5, 4, "How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?", "How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test? Armando Nava Jr. (a.k.a NavaTheBeast) served in the U.S.Marines for four years before taking to YouTube to vlog about life after the military.While he’s not training with SWAT teams and teaching powerlifters how to crush the brutal Marine Corps.physical fitness test, Nava can be found demonstrating the extensive lessons he learned from the Marines while putting his body through hell. In a recent video, Nava brought his friend and fellow veteran, Marcus Perez in front of the camera to see if they could both take on the famously grueling U.S.Navy SEALs Physical Fitness Test(PFT). Nava's version of the test wasn't exactly what you'd have to take on if you were trying to be a SEAL yourself—the standard test calls for a 500 yard swim in 12 minutes, 30 seconds, 50 pushups in 2 minutes, at least 50 curlups (situps) in 2 minutes, at least 10 pullups in 2 minutes, and a 1.5 mile run in at least 10 minutes and 30 seconds. Nava and Perez flip the order and do the run first, then skip the curlups entirely. Since they're not planning to enlist, we'll cut them some slack. The first portion of the test is a 1.5 mile run, which Nava knocks out in 10 minutes and eight seconds—about 6:39 per mile. Perez’ time is considerably slower but finishes in just under 17 minutes. “I haven’t run in a minute,” says an out of breath Nava, but this is a good start.” With Marcus running in the background, Nava reminds his audience to use his video for inspiration as what he’s doing is “easy to watch, but hard to do.” Next up: pushups.Navy SEALs need to do at least 98 reps to qualify for the Optimum distinction; Nava and Perez are aiming for 100.The guys hammer away at the 100 - pushup goal, sweating through the pain as Nava narrates. “The only way you’re gonna get better is by putting yourself through that pain and that suffering, because that’s what’s going to mold you and that’s what’s going to make you a stronger individual.” Seventy pushups in, Nava is unable to continue and taps out of the challenge, while Marcus just makes it to 100.As the guys rise from the floor, physically shaking, they head inside to handle the next portion of the fitness test: pullups. Nava and Marcus only have to make it to 15 to meet the Optimum requirement, but they aim for 20.After each hitting the target reps, Marcus and Nava head out to conquer the very last challenge: a 500 - meter swim. “We pushing through this pain,” says Nava as he prepares to swim 10 laps, “and so should you.Let’s go finish this test.” The guys absolutely go beast - mode during the final swim, clocking in at eight minutes and five seconds. “I’m sore and hungry,” says Marcus, “I’m just glad I attempted it.” As the video wraps, Nava once again tells viewers to not only watch his videos but go out and actually do what he’s doing yourself. After a 1.5 mile run, pushups, pullups, and a swim, Nava showcases the physical toll the body goes through to make the cut for the elite branches of the military.", "How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?", "9.0", "Кроссфит,Лёгкая атлетика", null },
                    { 2, 5, "This article provides a few key tips on how to perform the deadlift more efficiently and safely. Some helpful coaching cues—such as keeping the head slightly up, activating the lats, and pushing the knees out—can assist a tactical athlete in executing the deadlift while increasing strength over time.", "It is becoming a more common idea that strength training should be utilized in every population for maintaining general health and varied performance goals. There is a growing body of anecdotal evidence showing the benefits of including general strength training in populations where it was previously ignored or deemed harmful. However, there is still confusion on how to best implement strength training in programs focused on sport performance, rehabilitation, or general health. Hopefully this article can provide insight and guidance on how to use one of the most important strength movements—the deadlift.The deadlift should be a staple for not only increasing performance but also overall resiliency.Almost every job in any tactical field(e.g., police, fire, military) requires stabilization of the trunk while expressing large amounts of force through the lower extremities. There are few exercises that will activate trunk muscles like the deadlift because it requires the entire body to be engaged for proper completion. The deadlift requires the upper and lower extremities to move or stabilize the bar, which engages a large number of motor units and muscles fibers simultaneously.In terms of positive changes and strength progressions in short - or long - term adaptation, there are few substitutes for the deadlift. Its simplicity and function should make it a priority in all strength training regimens.The positive changes in bone density, muscle mass, resting metabolic rate, decreased low back pain, and even dynamic strength development emphasize the importance of the deadlift(1, 2, 3).Research has also shown that long - term lifting with deadlifts and squats not only promotes an increase of bone density in younger populations, but it may also help maintain that increase well into the later stages of life(1, 4, 5).The coordinated effort required to perform the deadlift, and its variations, places a large amount of stress on the musculoskeletal system and drives adaptation.The deadlift is a base for all other ground - based lifts(e.g., cleans, snatches, and their variations) as well as many tactical agility tests(e.g., dummy drags, equipment lifting, patient loading, etc.).Proper execution of the deadlift, and the ability to stabilize the trunk and spine while exerting maximal effort is a skill that can help tactical personnel and the general population avoid injury.The deadlift should be a staple for not only increasing performance but also overall resiliency.Almost every job in any tactical field(e.g., police, fire, military) requires stabilization of the trunk while expressing large amounts of force through the lower extremities. There are few exercises that will activate trunk muscles like the deadlift because it requires the entire body to be engaged for proper completion. The deadlift requires the upper and lower extremities to move or stabilize the bar, which engages a large number of motor units and muscles fibers simultaneously.There are a few key pointers that advanced coaches and lifters can use in order to achieve excellent results while reducing the risk of injury and promoting safe motor patterns.The remainder of this article will present four of the most important tips for deadlifting from an anecdotal base to not only increase performance, but also to decrease injury rates in tactical populations.TIP 1 | Head Posture: The Head Needs To Be Looking Slightly UpwardThere has been a lot of debate with this topic, but keeping the head looking slightly upward allows the shoulders to stay back and the spine to stay in a more erect, and neutral, position.Half of the battle with performing near - maximal deadlifts and doing it safely is keeping the back as neutral as possible with the head in a more upright position, which keeps the hips and leg extensors working at the same time.Often if the head falls forward or the eyes drift downward while performing the lift, it can cause the weight to be distributed over the leg extensors and reduce the involvement of the hips and posterior chain.It has been debated that a “head up” position can cause cervical spine issues, but research is currently lacking to warrant such concern. Hundreds, if not thousands, of powerlifters have lifted this way for many years, and cervical spine injury has not become an epidemic in this population, or been at a high enough prevalence to cause concern.A more vertical, and neutral, back position allows for increased hip drive, which can be better utilized with the head looking slightly upward.From experience, often a slightly upward head angle results in better deadlift form.TIP 2 | Lat Activation: The Lats Need to Engage FirstThis allows the bar path to be as close to the legs as possible.By contracting the lats first, the bar stays closer to the lower extremities and gives the hips and legs more leverage to perform the task.The further the bar is away from the legs, the more the lower back has to activate to perform the lift.A great deadlift should leave marks on the shins.This indicates that the bar was as close to the lower extremities as possible, and the bar weight was kept as close as possible to the lifter’s center of mass.This activation of the lats can create a posture that is advantageous to lifting large loads safely by creating tension on the bar prior to initiating the lift.Advanced lifters may actually try to bend the bar with the lats while the barbell is on the ground, to ensure the bar stays close to the body.This preliminary activation of the lats also reduces the tendency for the shoulders to drop, keeping the thoracic and lumbar spine more vertical and less likely to round.TIP 3 | Knee Motion Cues: Regardless of Position(Sumo, Conventional, or Some Variation) Always Try to Push the Knees ApartPushing the knees apart throughout the deadlift can help the glutes remain active during the lift.When first learning, most people will tend to use all quads, hamstrings, and spinal erectors to pull the weight up off the ground.By driving the knees apart, the glute medius will be triggered to stabilize the pelvis and help the posterior chain to maximize hip extension.This is crucial with not only coaching, but also lifting larger loads(i.e., 80 % of one repetition maximum[1RM] or higher).This key coaching cue can allow the athlete to lift more weight by including more muscle groups throughout the entire lift.Another helpful tip is to try to spread the floor with the feet.This lateral pressure can force the knees outward and ensure a strong supportive base from which to lift.TIP 4 | Positional Weakness: Train Your Weakest PositionMany times when an athlete first starts to deadlift, one position feels more natural or stronger(usually conventional) than others. An athlete will tend to gravitate towards this stronger position naturally.However, it can be very helpful to focus on the position that feels weaker and more awkward for long - term improvement.For my tactical athletes and general clients, it is valuable for them to become proficient in sumo deadlifting before utilizing a conventional stance.There are a few reasons for this:It teaches the lifter to use the hips primarily, which can reduce the risk of excessive lumber flexion under load.Hip strength and mobility are crucial in general performance.One of the main indicators of future lower back problems and / or health is hip mobility. Completing sumo deadlifts correctly can aid in developing strong hips, as well as improving mobility.From experience, sumo deadlifts can actually help one learn to pull conventional deadlifts correctly, by first addressing hip mobility and learning how to maximally activate the glutes.This allows the lifter to take some pressure off the lower back and place it on the glutes.The sumo deadlift seems to be able to withstand more volume in a training block or cycle than deadlifting with a conventional stance.A logical reason for this is that the sumo stance utilizes less lower back musculature and more of the glutes.Since the glutes are larger, and more powerful, they can handle the increased training volume when compared to the lower back.From experience, the sumo deadlift can be used more frequently and with higher resistances for longer periods of time than the conventional deadlift(assuming the lifter is healthy).Hopefully this article has provided a few key tips on how to perform the deadlift more efficiently and safely.Some helpful coaching cues, like keeping the head slightly up, activating the lats, and pushing the knees out can assist a tactical athlete in executing the deadlift while increasing strength over time.", "article provides a few key tips on how to perform the deadlift more efficiently and safely", "10.0", "Кроссфит,Тренировки", null }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Description", "EmblemHallId", "Location", "Name", "Rating", "Town", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "DOG – первый фитнес клуб Киева, который получил официальную CrossFit сертификацию. Высокие стандарты обслуживания, качества оборудования и подхода к тренировкам обязательны для получения сертификации.Титулованный тренерский состав и профессиональное оборудование сделают ваши занятия более эффективными и помогут выйти на новый уровень физической подготовки.Главные тренера клубов ДОГ - Валентин Литвинчук и Леонид Леус - настоящие профессионалы которые стоят у истоков развития Кроссфита в Украине Более 50 различных & nb...", 1, "Днепровская набережная, 14К", "DOG & GRAND CROSSFIT", null, "Киев", "Affiliate Crossfit,Boxing,Fitness,Gym,MMA,Yoga", null },
                    { 2, null, 2, "пр. Тракторостроителей 57б", "M4", "10.0", "Харьков", "Crossfit (not Aff.)", null },
                    { 3, "Самая крупная сеть клубов в Западной Украине. 5 специализированных залов со всем необходимым оборудованием в городе Льва. Площадь залов составляет от 400 до 2500кв.м. Залы условно поделены на зоны от кардио до тяжёлой атлетики и кроссфит зон. Качественная система вентиляции и кондиционирования делает занятия ещё эффективней. Общая сауна для отдыха.Квалифицированные тренера, которые помогут даже в скретчинге и диетологии. Олимп рекомендует Василий Вирастюк.", 3, null, "Олимп", "10.0", "Львов", "Crossfit (not Aff.),Fitness,Gym,Yoga", null },
                    { 5, "Blas (CrossFit — BLaS CA! BLaS = Body Like a Stone) Crossfit Area, Днепр. Целый спортивный комплекс на берегу Днепра - 300 кв.м. Единственный аффилированный зал в городе.Персональные тренировки по всем направлениям, в том числе Crossfit Kids.Отличная команда тренеров.Профессиональное оборудование Rogue(3 тонны железа), кроссфит - рама, 2 Air Bikes, 10 гребных тренажёров Concept.Массажный кабинет, фитнес - бар с самыми лучшими коктейлями, детская комната, если негде оставить ребенка.", 4, "улица Набережная Победы, 62", "BLaS CrossFit Area", null, "Днепр", "Affiliate Crossfit,Fitness,Gym", null },
                    { 4, "Первая сеть кроссфит-залов в Киеве - 4 зала в разных районах города и локации для бесплатных тренировок. Самый большой из них - площадью в 1200 кв.м. Сертифицированные тренера.Физическая реабилитация после травм.Команда Banda Crossfit принимает участие в благотворительном забеге Wings for Life World Run.Клуб проводит все украинские турниры по кроссфиту Banda Arena Challenge.Скретчинг, настольный теннис для отдыха.Школа тренеров, семинары, собственная лаборатория Banda Lab.Множество мероприятий и партнёров.", 5, "Новопечерский переулок, 5", "Crossfit Banda", "5.0", "Киев", "Affiliate Crossfit,Fitness,Gym,Weightlifting,Yoga", null }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Aim", "Description", "HallId", "Name", "ProgramsEmblemId", "Rating", "Type" },
                values: new object[,]
                {
                    { 2, "На силу", "План, для аматоров CrossFit План для тренировок в зале с использованием упражнений на силу и выносливость, состоящая в основном из аэробных упражнений, гимнастики (упражнения с весом собственного тела) и тяжёлой атлетики, для людей которые имеют слабую или среднюю базовую подготовку, с целью поддержания и увеличиния физической формы. Если твой уровень выше чем этот то тебе на этот план------> CoachMarchenko", null, "Plan for the amateur", 5, null, "Тяжелая атлетика" },
                    { 5, "Performance", null, null, "NRC 21.1 Prep", 4, null, "Фитнесс" }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "AnswerId", "Name" },
                values: new object[,]
                {
                    { 9, 9, "Можно ли редактировать или удалить программу тренировок, тренировку или упражнения?" },
                    { 1, 1, "Как добавить результат о тренировке?" },
                    { 3, 2, "Как присоединиться к залу?" },
                    { 2, 3, "Как получить баллы?" },
                    { 4, 4, "Как поднятся в рейтинге игроков?" },
                    { 5, 5, "Какие залы можно редактировать и удалять?" },
                    { 6, 6, "Как начать тренировку?" },
                    { 7, 7, "Можно ли редактировать или удалить результат тренировки?" },
                    { 8, 8, "Зачем нужна программа тренировок?" },
                    { 10, 10, "Как получить баллы за мероприятие?" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AboutMe", "Birthday", "Country", "Email", "EventId", "GenderId", "HallId", "Height", "Name", "NickName", "Password", "Points", "ProgramId", "Surname", "Town", "Weight" },
                values: new object[,]
                {
                    { 1, "I am a developer C#", new DateTime(2003, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukraine", "deniskudravov228@gmail.com", null, 1, null, "185", "Денис", "SoEasyBlef", "0000", 185, null, "Кудрявов", "Херсон", "70" },
                    { 2, "Test Nata", new DateTime(2000, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ukraine", "nata@gmail.com", null, 2, null, "175", "Наташа", "Nat25", "0000", 45, null, "Возникова", "Херсон", "55" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Aim", "Description", "HallId", "Name", "ProgramsEmblemId", "Rating", "Type" },
                values: new object[,]
                {
                    { 1, "Набор мышечной массы", "Программа тренировок состоит из 38 комплексов с большим преобладанием коротких силовых тренировок и полным отсутствием кардио нагрузки. План тренировок подойдет, если ваша цель - увеличение силы и прирост мышечной масса в ущерб выносливости. План тренировок комбинирует в себе силовые тренировки и короткие “тяжелые” комплексы кроссфит, преобладают базовые упражнения с большими весами на малое кол-во повторов, что является основным условием развития силы и набора массы (мышечной массы) В данной программе встречаются технически сложные тяжелоатлетические упражнения, поэтому обязательно пр...", 1, "Программа тренировки кроссфит на массу", 3, "8.0", "Кроссфит" },
                    { 3, "Fitness", "Программа тренировок идеально подойдет для новичков. Большая часть плана состоит из гимнастических тренировок со своим весом и не требует вспомогательных предметов для выполнения. Сами же упражнения очень просты и наверняка давно вам знакомы, поэтому вы можете не обладать специальными знаниями, чтобы заниматься по данному плану. С этой программой вам не нужно обязательно быть в зале во время тренировки, вы можете выполнять тренировки в любом удобном месте.", 2, "Кроссфит программа тренировок дома без оборудования", 1, null, "Кроссфит" },
                    { 4, "Fitness", "План тренировки рассчитан на людей решивших начать тренировки по системе Кроссфит. Тренировочный план сбалансированный, используются только базовые и упрощенные упражнения. Но если Вы не имеете опыта выполнения данных упражнений, обязательно выполнение данного плана под руководством сертифицированного тренера", 3, "Вводной план тренировок для новичков в Кроссфите", 2, "10.0", "Кроссфит" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Category", "Complexity", "HallId", "Modality", "Name", "Rating", "Time" },
                values: new object[,]
                {
                    { 1, "Singlet,Bodyweight,For-Time", "Легкий", 1, "G", "100 Burpees", "7.0", new TimeSpan(0, 0, 23, 20, 0) },
                    { 3, "Couplet,Bodyweight,ForTime,Rower", "Нормальный", 1, "GM", "Titan wod", "10.0", new TimeSpan(0, 0, 24, 0, 0) },
                    { 4, "Couplet,ForTime,Kettlebell", "Нормальный", 2, "WM", "Вместе Навсегда", "8.0", new TimeSpan(0, 0, 16, 25, 0) },
                    { 6, "Triplet,For-Time", "Нормальный", 3, "WGM", "Siberian Bears", "7.5", new TimeSpan(0, 0, 19, 0, 0) },
                    { 7, "Couplet,For-Time", "Легкий", 5, "WG", "08022014", "8.0", new TimeSpan(0, 0, 29, 6, 0) },
                    { 2, "Couplet,Bodyweight,For-Time", "Сложный", 4, "GM", "1000", "8.5", new TimeSpan(0, 0, 50, 30, 0) },
                    { 5, "Endurance,Singlet,AMRAP", "Легкий", 4, "M", "Jumping300", "6.5", new TimeSpan(0, 0, 5, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "ProgramsWorkouts",
                columns: new[] { "Id", "ProgramsId", "WorkoutsId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 8, 4, 2 },
                    { 12, 5, 5 },
                    { 10, 4, 4 },
                    { 9, 4, 3 },
                    { 2, 1, 2 },
                    { 6, 3, 2 },
                    { 5, 2, 3 },
                    { 3, 1, 3 },
                    { 7, 3, 5 },
                    { 11, 5, 1 },
                    { 4, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "WorkoutsExercises",
                columns: new[] { "Id", "ExercisesId", "Work", "WorkoutsId" },
                values: new object[,]
                {
                    { 11, 11, "100", 2 },
                    { 10, 10, "100", 2 },
                    { 9, 9, "100", 2 },
                    { 8, 8, "100", 2 },
                    { 6, 6, "100", 2 },
                    { 5, 5, "100", 2 },
                    { 4, 5, "100", 2 },
                    { 3, 3, "100", 2 },
                    { 2, 2, "100", 2 },
                    { 12, 12, "100", 2 },
                    { 7, 7, "100", 2 },
                    { 24, 8, "100", 6 },
                    { 25, 12, "10", 7 },
                    { 23, 7, "20", 6 },
                    { 22, 5, "10", 6 },
                    { 20, 7, "75", 4 },
                    { 19, 3, "75", 4 },
                    { 18, 12, "75", 4 },
                    { 17, 9, "75", 4 },
                    { 16, 1, "300 meters", 4 },
                    { 15, 11, "50", 3 },
                    { 14, 7, "50", 3 },
                    { 13, 1, "1000 meters", 3 },
                    { 1, 4, "100", 1 },
                    { 26, 9, "20", 7 },
                    { 21, 10, null, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleEmblemId",
                table: "Articles",
                column: "ArticleEmblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventsEmblemId",
                table: "Events",
                column: "EventsEmblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_HallId",
                table: "Events",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_WorkoutId",
                table: "Events",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTimeUser_EventsId",
                table: "EventTimeUser",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTimeUser_UserId",
                table: "EventTimeUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_EmblemHallId",
                table: "Halls",
                column: "EmblemHallId");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_UserId",
                table: "Halls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_HallId",
                table: "Programs",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_ProgramsEmblemId",
                table: "Programs",
                column: "ProgramsEmblemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramsWorkouts_ProgramsId",
                table: "ProgramsWorkouts",
                column: "ProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramsWorkouts_WorkoutsId",
                table: "ProgramsWorkouts",
                column: "WorkoutsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramTimeUser_ProgramsId",
                table: "ProgramTimeUser",
                column: "ProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramTimeUser_UserId",
                table: "ProgramTimeUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerId",
                table: "Question",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultWorkouts_UserId",
                table: "ResultWorkouts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultWorkouts_WorkoutId",
                table: "ResultWorkouts",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email_NickName",
                table: "User",
                columns: new[] { "Email", "NickName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_EventId",
                table: "User",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderId",
                table: "User",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_User_HallId",
                table: "User",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProgramId",
                table: "User",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_HallId",
                table: "Workouts",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutsExercises_ExercisesId",
                table: "WorkoutsExercises",
                column: "ExercisesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutsExercises_WorkoutsId",
                table: "WorkoutsExercises",
                column: "WorkoutsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_User_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Halls_HallId",
                table: "Events",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_User_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Workouts_WorkoutId",
                table: "Events",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventTimeUser_User_UserId",
                table: "EventTimeUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Halls_HallId",
                table: "User",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Programs_ProgramId",
                table: "User",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_User_UserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Halls_User_UserId",
                table: "Halls");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "EventTimeUser");

            migrationBuilder.DropTable(
                name: "ProgramsWorkouts");

            migrationBuilder.DropTable(
                name: "ProgramTimeUser");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ResultWorkouts");

            migrationBuilder.DropTable(
                name: "WorkoutsExercises");

            migrationBuilder.DropTable(
                name: "ArticleEmblem");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "EventEmblem");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "ProgramEmblem");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "HallEmblem");
        }
    }
}
