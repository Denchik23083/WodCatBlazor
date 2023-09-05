using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class AboutHallComponent
    {
        [Parameter] public Halls Hall { get; set; } = new();

        public int Athletes { get; set; }

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            if (Hall?.Users is not null)
            {
                Athletes = Hall!.Users!.Count;
            }
        }
    }
}
