using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class FilterHallsComponent
    {
        [Parameter] public IEnumerable<Halls> Halls { get; set; }

        [Inject] public IHallsService _service { get; set; }

        private string _filterTown = "None";
        private string _filterType = "None";

        public List<FilterHalls> FilterTown = new()
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
            new() { Content = "Львов", Filter = "Львов" },
        };

        public List<FilterHalls> FilterType = new()
        {
            new() { Content = "Crossfit (not Aff.)", Filter = "Crossfit (not Aff.)" },
            new() { Content = "Affiliate Crossfit", Filter = "Affiliate Crossfit," },
            new() { Content = "Gym", Filter = "Gym" },
            new() { Content = "Boxing", Filter = "Boxing" },
            new() { Content = "Fitness", Filter = "Fitness" },
            new() { Content = "MMA", Filter = "MMA" },
            new() { Content = "Weightlifting", Filter = "Weightlifting" },
            new() { Content = "Yoga", Filter = "Yoga" },
        };

        public void Filter()
        {
            Halls = _service.GetAllHalls();

            if (_filterTown != "None")
            {
                Halls = Halls.Where(b => b.Location.Contains(_filterTown)).ToList();
            }
            if (_filterType != "None")
            {
                Halls = Halls.Where(b => b.Type.Contains(_filterType)).ToList();
            }
        }

        public void Reset()
        {
            _filterTown = "None";
            _filterType = "None";

            Filter();
        }
    }
}