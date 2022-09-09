using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Web.Utilities;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class FilterWorkoutsComponent
    {
        [Parameter] public IEnumerable<Workouts> Workouts { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        public bool IsVisible { get; set; }

        public string Visible = "hidden";

        public void ChangeVisible()
        {
            IsVisible = !IsVisible;

            Visible = IsVisible ? "visible" : "hidden";
        }

        private string _filterName = string.Empty;
        private string _filterCategory = "None";
        private string _filterModality = "None";
        private string _filterComplexity = "None";
        private int _filterTime = 0;

        public List<FilterWorkouts> FilterCategory = new()
        {
            new() { Content = "Singlet", Filter = "Singlet" },
            new() { Content = "Bodyweight", Filter = "Bodyweight" },
            new() { Content = "For-Time", Filter = "For-Time" },
            new() { Content = "Rower", Filter = "Rower" },
            new() { Content = "Kettlebell", Filter = "Kettlebell" },
            new() { Content = "Couplet", Filter = "Couplet" },
            new() { Content = "Endurance", Filter = "Endurance" },
            new() { Content = "AMRAP", Filter = "AMRAP" },
            new() { Content = "Triplet", Filter = "Triplet" },
        };

        public List<FilterWorkouts> FilterModality = new()
        {
            new() { Content = "G", Filter = "G" },
            new() { Content = "GM", Filter = "GM" },
            new() { Content = "M", Filter = "M" },
            new() { Content = "WM", Filter = "WM" },
            new() { Content = "WGM", Filter = "WGM" },
            new() { Content = "WG", Filter = "WG" },
        };
        
        public List<FilterWorkouts> FilterComplexity = new()
        {
            new() { Content = "Легкий", Filter = "Легкий" },
            new() { Content = "Нормальный", Filter = "Нормальный" },
            new() { Content = "Сложный", Filter = "Сложный" },
        };

        public async Task Filter()
        {
            Workouts = await WorkoutsService.GetAllWorkouts();

            if (!string.IsNullOrWhiteSpace(_filterName))
            {
                Workouts = Workouts.Where(b => b.Name.ToLower().Contains(_filterName.ToLower())).ToList();
            }
            if (_filterCategory != "None")
            {
                Workouts = Workouts.Where(o => o.Category.Contains(_filterCategory)).ToList();
            }
            if (_filterModality != "None")
            {
                Workouts = Workouts.Where(b => b.Modality.Equals(_filterModality)).ToList();
            }
            if (_filterComplexity != "None")
            {
                Workouts = Workouts.Where(b => b.Complexity.Equals(_filterComplexity)).ToList();
            }
            if (_filterTime != 0)
            {
                Workouts = Workouts.Where(b => b.Time.Minutes.Equals(_filterTime)).ToList();
            }
        }

        public async Task Reset()
        {
            _filterName = string.Empty;
            _filterCategory = "None";
            _filterModality = "None";
            _filterComplexity = "None";
            _filterTime = 0;

            await Filter();
        }
    }
}
