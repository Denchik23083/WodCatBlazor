using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class IndividualHallsComponent
    {
        [Parameter] public Halls Hall { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        public string[] HallType { get; set; }

        public string Image { get; set; }

        public int Value { get; set; }

        public string Url = string.Empty;

        public int Athletes { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Value = 0;
            Url = $"gymboxs/{Hall.Id}";
            Image = await HallsService.GetImage(Hall.EmblemHallId);
            if (Hall.Type is not null)
            {
                HallType = Hall.Type.Split(",");
            }
            Athletes = HallsService.Athlete(Hall.Id);
        }

        protected override async Task OnParametersSetAsync()
        {
            Value = 0;
            Url = $"gymboxs/{Hall.Id}";
            Image = await HallsService.GetImage(Hall.EmblemHallId);
            if (Hall.Type is not null)
            {
                HallType = Hall.Type.Split(",");
            }
            Athletes = HallsService.Athlete(Hall.Id);
        }
    }
}
