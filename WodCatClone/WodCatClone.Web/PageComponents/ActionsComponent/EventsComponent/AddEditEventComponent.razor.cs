using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;
using WodCatClone.Web.Utilities;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class AddEditEventComponent
    {
        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Parameter] public bool Edit { get; set; }

        [Parameter] public bool Add { get; set; }

        [Parameter] public int EventId { get; set; }

        public IEnumerable<EventEmblem> EventEmblem { get; set; }

        public IEnumerable<Halls> Halls { get; set; }
        
        public IEnumerable<HallEmblem> HallEmblem { get; set; }

        public IEnumerable<Workouts> Workouts { get; set; }

        public bool IsBadLeftSite { get; set; }

        public Events Event { get; set; }

        public Workouts Workout { get; set; }
        
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

        public List<FilterEvents> TypeEvent = new()
        {
            new() { Content = "Выставки", Filter = "Выставки" },
            new() { Content = "N/A", Filter = "N/A" },
            new() { Content = "Онлайн соревнования", Filter = "Онлайн соревнования" },
            new() { Content = "Cеминар", Filter = "Cеминар" },
            new() { Content = "Соревнования", Filter = "Соревнования" },
        };

        public List<FilterEvents> TypeSport = new()
        {
            new() { Content = "Лёгкая атлетика", Filter = "Лёгкая атлетика" },
            new() { Content = "Бодибилдинг", Filter = "Бодибилдинг" },
            new() { Content = "Бокс", Filter = "Бокс" },
            new() { Content = "Фитнесс", Filter = "Фитнесс" },
            new() { Content = "Кроссфит", Filter = "Кроссфит" },
            new() { Content = "Гиревой спорт", Filter = "Гиревой спорт" },
            new() { Content = "Мотокросс", Filter = "Мотокросс" },
            new() { Content = "Пауэрлифтинг", Filter = "Пауэрлифтинг" },
            new() { Content = "Стронгмен", Filter = "Стронгмен" },
            new() { Content = "Тяжелая атлетика", Filter = "Тяжелая атлетика" },
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
                Event = new Events();
            }
            else
            {
                Event = EventsService.GetEvent(EventId);
                Image = EventsService.GetImage(Event.EventsEmblemId);
                var hall = HallsService.GetHall(Event.HallId);
                HallImage = HallsService.GetImage(hall.EmblemHallId);
                Workout = WorkoutsService.GetWorkout(Event.WorkoutId);
                WorkoutImage = Workout.Name;
            }

            EventEmblem = EventsService.GetAllEventEmblem();
            Halls = HallsService.GetAllHalls();
            HallEmblem = HallsService.GetAllHallEmblem();
            Workouts = WorkoutsService.GetAllWorkouts();
        }

        public async Task Submit()
        {
            var isValid = Validation();

            if (isValid)
            {
                if (Add)
                {
                    var result = await EventsService.AddEvent(Event);
                    NavigationManager.NavigateTo(result ? "/events" : "/events/add");
                }
                if (Edit)
                {
                    var result = await EventsService.EditEvent(Event, EventId);
                    NavigationManager.NavigateTo(result ? $"/events/{EventId}" : $"/events/{Event}/edit");
                }
            }
        }

        private bool Validation()
        {
            if (Event.RegisterDate > DateTime.Now
                && Event.StartDate > DateTime.Now
                && Event.EndDate > DateTime.Now
                && Event.RegisterDate < Event.StartDate
                && Event.StartDate < Event.EndDate)
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

            Image = selected;

            var eventEmblem = EventEmblem.FirstOrDefault(b => b.Image.Equals(selected));

            if (eventEmblem is not null) Event.EventsEmblemId = eventEmblem.Id;
        }

        public void SelectedHallImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();
            
            if (selected != "None")
            {
                var id = int.Parse(e.Value!.ToString()!);

                var hall = HallsService.GetHall(id);
                var eventHallEmblem = HallEmblem.FirstOrDefault(b => b.Id == hall.EmblemHallId);

                if (eventHallEmblem is not null)
                {
                    HallImage = eventHallEmblem.Image;
                    Event.HallId = hall.Id;
                }
            }
            else
            {
                HallImage = selected;
            }
        }

        public void SelectedWorkoutImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            if (selected != "None")
            {
                var id = int.Parse(e.Value!.ToString()!);

                var workout = WorkoutsService.GetWorkout(id);

                if (workout is not null)
                {
                    Workout = workout;
                    WorkoutImage = workout.Name;
                    Event.WorkoutId = workout.Id;
                }
            }
            else
            {
                WorkoutImage = selected;
            }
        }
    }
}
