using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class AboutEventComponent
    {
        [Parameter] public Events? Event { get; set; } = new();
    }
}
