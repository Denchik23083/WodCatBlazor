using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class FilterRatingsComponent
    {
        [Parameter] public IEnumerable<User> Users { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public string _filterTown = "None";

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

        public void Filter()
        {
            Users = UserService.GetAllUsers();

            if (_filterTown != "None")
            {
                Users = Users.Where(b => b.Town.Contains(_filterTown)).ToList();
            }
        }

        public void Reset()
        {
            _filterTown = "None";

            Filter();
        }
    }
}
