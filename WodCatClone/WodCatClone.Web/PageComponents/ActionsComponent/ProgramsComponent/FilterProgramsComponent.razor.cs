using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class FilterProgramsComponent
    {
        [Parameter] public IEnumerable<Programs> Programs { get; set; } = new List<Programs>();

        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

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
            new() { Content = "Performance", Filter = "Performance" },
        };

        public async Task Filter()
        {
            Programs = await ProgramsService.GetAllProgramsAsync();

            if (_filterType != "None")
            {
                Programs = Programs.Where(b => b.Type!.Equals(_filterType)).ToList();
            }
            if (_filterAim != "None")
            {
                Programs = Programs.Where(b => b.Aim!.Equals(_filterAim)).ToList();
            }
        }

        public async Task Reset()
        {
            _filterType = "None";
            _filterAim = "None";

            await Filter();
        }
    }
}
