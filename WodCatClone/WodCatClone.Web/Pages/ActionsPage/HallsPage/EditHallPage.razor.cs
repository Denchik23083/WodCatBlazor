using Microsoft.AspNetCore.Components;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class EditHallPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public NavigationManager _navigationManager { get; set; }

        public void BackToGymList() => _navigationManager.NavigateTo($"/gymboxs/{HallId}");
    }
}
