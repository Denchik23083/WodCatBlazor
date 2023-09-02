using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class AwardsComponent
    {
        [Parameter] public IEnumerable<EventTimeUser> ListOfItems { get; set; } = new List<EventTimeUser>();

        public int Places { get; set; }

        public int Points { get; set; }

        protected override void OnInitialized()
        {
            Places = 0;
            Points = 200;
        }
    }
}
