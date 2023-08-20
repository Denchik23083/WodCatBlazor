using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class FilterRatingsComponent
    {
        [Parameter] public IEnumerable<User> Users { get; set; } = new List<User>();

        [Inject] public IUserService UserService { get; set; } = null!;

        private string _filterTown = "None";

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
            new() { Content = "Запорожье", Filter = "Запорожье" },
            new() { Content = "Львов", Filter = "Львов" },
        };

        public async Task Filter()
        {
            Users = await UserService.GetAllUsers();

            if (_filterTown != "None")
            {
                Users = Users.Where(b => b.Town!.Contains(_filterTown)).ToList();
            }
        }

        public async Task Reset()
        {
            _filterTown = "None";

            await Filter();
        }
    }
}
