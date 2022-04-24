using Microsoft.AspNetCore.Components;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class AddHallPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        public void BackToGymList() => NavigationManager.NavigateTo("/gymboxs");
    }
}
