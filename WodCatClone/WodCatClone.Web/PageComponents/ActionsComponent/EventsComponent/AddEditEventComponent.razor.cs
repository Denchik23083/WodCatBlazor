using AutoMapper;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Web.Models;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class AddEditEventComponent
    {
        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        [Parameter] public Events Event { get; set; } = new();

        [Parameter] public bool Edit { get; set; }

        [Parameter] public bool Add { get; set; }

        [Parameter] public int EventId { get; set; }

        [Parameter] public IEnumerable<EventEmblem> EventEmblem { get; set; } = new List<EventEmblem>();

        [Parameter] public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();
        
        [Parameter] public IEnumerable<HallEmblem> HallEmblem { get; set; } = new List<HallEmblem>();

        [Parameter] public IEnumerable<Workouts> Workouts { get; set; } = new List<Workouts>();

        public bool IsBadLeftSite { get; set; }

        public EventsModel? UpdateEvent { get; set; } = new();

        public Workouts? Workout { get; set; } = new();

        public Halls? Hall { get; set; } = new();
        
        public bool IsFallEvent { get; set; }

        public string Image = "None";

        public string HallImage = "None";

        public string WorkoutImage = "None";

        public List<FilterEvents> Town = new()
        {
            new() { Content = "Херсон", Filter = "Херсон" },
            new() { Content = "Киев", Filter = "Киев" },
            new() { Content = "Харьков", Filter = "Харьков" },
            new() { Content = "Николаев", Filter = "Николаев" },
            new() { Content = "Одесса", Filter = "Одесса" },
            new() { Content = "Черновцы", Filter = "Черновцы" },
            new() { Content = "Днепр", Filter = "Днепр" },
            new() { Content = "Хмельницкий", Filter = "Хмельницкий" },
            new() { Content = "Кривой Рог", Filter = "Кривой Рог" },
            new() { Content = "Запорожье", Filter = "Запорожье" },
            new() { Content = "Львов", Filter = "Львов" },
        };

        public List<EventTypes> TypeEvent = new()
        {
            new() { Content = "Выставки", Value = "Выставки" },
            new() { Content = "N/A", Value = "N/A" },
            new() { Content = "Онлайн соревнования", Value = "Онлайн соревнования" },
            new() { Content = "Cеминар", Value = "Cеминар" },
            new() { Content = "Соревнования", Value = "Соревнования" },
        };

        public List<SportType> TypeSport = new()
        {
            new() { Content = "Лёгкая атлетика", Value = "Лёгкая атлетика" },
            new() { Content = "Бодибилдинг", Value = "Бодибилдинг" },
            new() { Content = "Бокс", Value = "Бокс" },
            new() { Content = "Фитнесс", Value = "Фитнесс" },
            new() { Content = "Кроссфит", Value = "Кроссфит" },
            new() { Content = "Гиревой спорт", Value = "Гиревой спорт" },
            new() { Content = "Мотокросс", Value = "Мотокросс" },
            new() { Content = "Пауэрлифтинг", Value = "Пауэрлифтинг" },
            new() { Content = "Стронгмен", Value = "Стронгмен" },
            new() { Content = "Тяжелая атлетика", Value = "Тяжелая атлетика" },
        };

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            if (EventId == 0)
            {
                UpdateEvent = new EventsModel();
            }
            else
            {
                UpdateEvent = Mapper.Map<EventsModel>(Event);

                if (UpdateEvent.EventEmblem is not null)
                {
                    Image = UpdateEvent.EventEmblem.Image!;
                }

                if (UpdateEvent.Halls is not null)
                {
                    Hall = UpdateEvent.Halls!;
                    if (Hall is not null)
                    {
                        HallImage = Hall.EmblemHall!.Image!;
                    }
                }
                if (UpdateEvent.Workouts is not null)
                {
                    Workout = UpdateEvent.Workouts!;
                    if (Workout is not null)
                    {
                        WorkoutImage = Workout.Name!;
                    }
                }
            }
        }

        public async Task Submit()
        {
            var isValid = Validation();

            if (isValid)
            {
                if (Add)
                {
                    var mappedEvent = Mapper.Map<Events>(UpdateEvent);

                    var result = await EventsService.AddEventAsync(mappedEvent);

                    NavigationManager.NavigateTo(result ? "/events" : "/events/add");
                }
                if (Edit)
                {
                    var mappedEvent = Mapper.Map<Events>(UpdateEvent);

                    var result = await EventsService.EditEventAsync(mappedEvent, EventId);

                    NavigationManager.NavigateTo(result ? $"/events/{EventId}" : $"/events/{UpdateEvent}/edit");
                }
            }
        }

        public bool Validation()
        {
            if (UpdateEvent!.RegisterDate > DateTime.Now
                && UpdateEvent.StartDate > DateTime.Now
                && UpdateEvent.EndDate > DateTime.Now
                && UpdateEvent.RegisterDate < UpdateEvent.StartDate
                && UpdateEvent.StartDate < UpdateEvent.EndDate)
            {
                IsFallEvent = false;
                if (WorkoutImage is not "None" 
                    && HallImage is not "None" 
                    && Image is not "None")
                {
                    IsBadLeftSite = false;
                }
                else
                {
                    IsBadLeftSite = true;
                    return false;
                }
            }
            else
            {
                IsFallEvent = true;
                return false;
            }

            return true;
        }

        public void SelectedImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            Image = selected!;

            var eventEmblem = EventEmblem.FirstOrDefault(b => b.Image!.Equals(selected));

            UpdateEvent!.EventsEmblemId = eventEmblem?.Id;
        }

        public async Task SelectedHallImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();
            
            if (selected != "None")
            {
                var id = int.Parse(e.Value!.ToString()!);

                var hall = await HallsService.GetHallAsync(id);
                var eventHallEmblem = HallEmblem.FirstOrDefault(b => b.Id == hall!.EmblemHallId);

                if (eventHallEmblem is not null)
                {
                    HallImage = eventHallEmblem.Image!;
                    UpdateEvent!.HallId = hall!.Id;
                }
            }
            else
            {
                HallImage = selected;
            }
        }

        public async Task SelectedWorkoutImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            if (selected != "None")
            {
                var id = int.Parse(e.Value!.ToString()!);

                var workout = await WorkoutsService.GetWorkoutAsync(id);

                if (workout is not null)
                {
                    Workout = workout;
                    WorkoutImage = workout.Name!;
                    UpdateEvent!.WorkoutId = workout.Id;
                }
            }
            else
            {
                WorkoutImage = selected;
            }
        }
    }
}
