using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class AddHallComponent
    {
        [Inject] public IHallsService HallsService { get; set; }

        public IEnumerable<HallEmblem> HallEmblem { get; set; }

        public Halls AddHall = new();

        public int HallEmblemId { get; set; }

        public string _image = "None";

        protected override void OnInitialized()
        {
            HallEmblem = HallsService.GetAllHallEmblem();
        }

        public void Image()
        {
            var hallEmblem = HallEmblem.FirstOrDefault(b => b.Image == _image);

            HallEmblemId = hallEmblem!.Id;
        }
    }
}
