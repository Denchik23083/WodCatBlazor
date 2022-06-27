﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class FilterEventsComponent
    {
        [Parameter] public IEnumerable<Events> Events { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        private string _filterTown = "None";
        private string _filterTypeEvent = "None";
        private string _filterTypeSport = "None";

        public List<FilterEvents> FilterTown = new()
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

        public List<FilterEvents> FilterTypeEvent = new()
        {
            new() { Content = "Выставки", Filter = "Выставки" },
            new() { Content = "N/A", Filter = "N/A" },
            new() { Content = "Онлайн соревнования", Filter = "Онлайн соревнования" },
            new() { Content = "Cеминар", Filter = "Cеминар" },
            new() { Content = "Соревнования", Filter = "Соревнования" },
        };

        public List<FilterEvents> FilterTypeSport = new()
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

        public void Filter()
        {
            Events = EventsService.GetAllEvents();

            if (_filterTown != "None")
            {
                Events = Events.Where(b => b.Town.Contains(_filterTown)).ToList();
            }
            if (_filterTypeEvent != "None")
            {
                Events = Events.Where(b => b.TypeEvent.Contains(_filterTypeEvent)).ToList();
            }
            if (_filterTypeSport != "None")
            {
                Events = Events.Where(b => b.TypeSport.Contains(_filterTypeSport)).ToList();
            }
        }

        public void Reset()
        {
            _filterTown = "None";
            _filterTypeEvent = "None";
            _filterTypeSport = "None";

            Filter();
        }
    }
}
