using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class IndividualHallsComponent
    {
        [Parameter] public Halls Halls { get; set; }

        [Inject] public IWorkoutsService _workoutsService { get; set; }

        public string[] HallsType { get; set; }

        public string Image { get; set; }

        public string _url = string.Empty;
        public int value = 0;

        protected override void OnInitialized()
        {
            _url = $"gymbox/{Halls.Id}";
            HallsType = Halls.Type.Split(",");
            Image = _workoutsService.GetImage(Halls.EmblemHallId);
        }
    }
}
