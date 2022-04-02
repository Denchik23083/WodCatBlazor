using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class ListHallsComponent
    {
        [Parameter] public IEnumerable<Halls> ListOfItems { get; set; }
    }
}
