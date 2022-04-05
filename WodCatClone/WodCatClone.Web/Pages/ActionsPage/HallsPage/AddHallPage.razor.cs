using Microsoft.AspNetCore.Components;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class AddHallPage
    {
        [Inject] public NavigationManager _navigationManager { get; set; }

        public void BackToGymList() => _navigationManager.NavigateTo("/gymbox");
    }
}
