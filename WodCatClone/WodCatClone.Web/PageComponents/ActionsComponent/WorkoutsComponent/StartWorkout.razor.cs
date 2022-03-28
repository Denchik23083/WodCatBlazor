using Microsoft.AspNetCore.Components;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class StartWorkout
    {
        [Parameter] public EventCallback OnCancel { get; set; }

        public bool DisplayStartWorkout { get; set; }

        public void Show() => DisplayStartWorkout = true;

        public void Hide() => DisplayStartWorkout = false;
    }
}
