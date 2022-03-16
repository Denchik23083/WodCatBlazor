using Microsoft.AspNetCore.Components;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class EditDeleteResult
    {
        [Parameter] public EventCallback OnDelete { get; set; }

        [Parameter] public EventCallback OnEdit { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        public bool DisplayEditDeleteResult { get; set; }

        public void Show() => DisplayEditDeleteResult = true;

        public void Hide() => DisplayEditDeleteResult = false;
    }
}
