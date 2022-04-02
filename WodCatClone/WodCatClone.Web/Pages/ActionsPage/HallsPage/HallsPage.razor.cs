using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsPage
    {
        IEnumerable<Halls> Halls { get; set; }

        [Inject] public IHallsService _service { get; set; }

        protected override void OnInitialized()
        {
            Halls = _service.GetAllHalls();
        }
    }
}
