using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class ConfirmRemoveHall
    {
        [Parameter] public EventCallback OnShow { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public int HallId { get; set; }

        [Parameter] public Halls? Hall { get; set; } = new();

        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public bool DisplayRemoveHall { get; set; }

        public void Show() => DisplayRemoveHall = true;

        public void Hide() => DisplayRemoveHall = false;

        public async Task Remove()
        {
            var result = await HallsService.RemoveHallAsync(HallId);

            NavigationManager.NavigateTo(result ? "/gymboxs" : $"/gymboxs/{HallId}");
        }
    }
}
