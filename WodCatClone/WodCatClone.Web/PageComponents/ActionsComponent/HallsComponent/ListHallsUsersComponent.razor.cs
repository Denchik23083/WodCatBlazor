using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class ListHallsUsersComponent
    {
        [Parameter] public IEnumerable<User> ListOfItems { get; set; } = new List<User>();
    }
}
