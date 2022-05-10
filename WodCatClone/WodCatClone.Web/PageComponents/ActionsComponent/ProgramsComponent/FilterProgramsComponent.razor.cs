using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class FilterProgramsComponent
    {
        [Parameter] public IEnumerable<Programs> Programs { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        private string _filterType = "None";
        private string _filterAim = "None";

        public List<FilterPrograms> FilterType = new()
        {
            new() { Content = "Кроссфит", Filter = "Кроссфит" },
            new() { Content = "Тяжелая атлетика", Filter = "Тяжелая атлетика" },
            new() { Content = "Фитнесс", Filter = "Фитнесс" },
        };

        public List<FilterPrograms> FilterAim = new()
        {
            new() { Content = "На силу", Filter = "На силу" },
            new() { Content = "Набор мышечной массы", Filter = "Набор мышечной массы" },
            new() { Content = "Fitness", Filter = "Fitness" },
        };

        void Filter()
        {
            Programs = ProgramsService.GetAllPrograms();

            if (_filterType != "None")
            {
                Programs = Programs.Where(b => b.Type.Equals(_filterType)).ToList();
            }

            if (_filterAim != "None")
            {
                Programs = Programs.Where(b => b.Aim.Equals(_filterAim)).ToList();
            }
        }

        void Reset()
        {
            _filterType = "None";
            _filterAim = "None";

            Filter();
        }
    }
}
