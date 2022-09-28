using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class ListEventsComponent
    {
        [Parameter] public IEnumerable<Events> ListOfItems { get; set; }
    }
}
