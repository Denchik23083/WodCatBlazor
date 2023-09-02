using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class ListEventsUsersComponent
    {
        [Parameter] public IEnumerable<User> ListOfItems { get; set; } = new List<User>();
    }
}
