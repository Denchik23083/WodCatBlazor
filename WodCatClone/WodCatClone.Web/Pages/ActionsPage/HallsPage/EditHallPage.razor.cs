using Microsoft.AspNetCore.Components;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class EditHallPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public void BackToGymList() => NavigationManager.NavigateTo($"/gymboxs/{HallId}");
    }
}
