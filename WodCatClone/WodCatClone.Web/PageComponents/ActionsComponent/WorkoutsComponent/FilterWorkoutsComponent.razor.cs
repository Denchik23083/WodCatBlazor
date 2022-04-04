using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class FilterWorkoutsComponent
    {
        [Parameter] public IEnumerable<Workouts> Workouts { get; set; }

        [Inject] public IWorkoutsService _service { get; set; }

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
        private string _filterMovement = "None";
        private string _filterComplexity = "None";
        private string _filterInventory = "None";

        public List<FilterWorkouts> FilterCategory = new()
        {
            new() { Content = "Singlet", Filter = "Singlet" },
            new() { Content = "Bodyweight", Filter = "Bodyweight" },
            new() { Content = "For-Time", Filter = "For-Time" },
            new() { Content = "Rower", Filter = "Rower" },
            new() { Content = "Couplet", Filter = "Couplet" },
        };

        public List<FilterWorkouts> FilterModality = new()
        {
            new() { Content = "G", Filter = "G" },
            new() { Content = "GM", Filter = "GM" },
            new() { Content = "M", Filter = "M" },
        };

        public List<FilterWorkouts> FilterMovement = new()
        {
            new() { Content = "Бёрпи", Filter = "Бёрпи" },
            new() { Content = "Отжимание", Filter = "Отжимание" },
            new() { Content = "Взятия на грудь", Filter = "Взятия на грудь" },
        };
        
        public List<FilterWorkouts> FilterComplexity = new()
        {
            new() { Content = "Легкий", Filter = "Легкий" },
            new() { Content = "Нормальный", Filter = "Нормальный" },
            new() { Content = "Сложный", Filter = "Сложный" },
        };

        public List<FilterWorkouts> FilterInventory = new()
        {
            new() { Content = "Нет", Filter = "Нет" },
            new() { Content = "Скакалка", Filter = "Скакалка" },
            new() { Content = "Ящик для прыжков", Filter = "Ящик для прыжков" },
        };

        void Filter()
        {
            Workouts = _service.GetAllWorkouts();

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

            if (_filterMovement != "None")
            {
                Workouts = Workouts.Where(b => b.Movement.Contains(_filterMovement)).ToList();
            }

            if (_filterComplexity != "None")
            {
                Workouts = Workouts.Where(b => b.Complexity.Equals(_filterComplexity)).ToList();
            }

            if (_filterInventory != "None")
            {
                Workouts = Workouts.Where(b => b.Inventory.Equals(_filterInventory)).ToList();
            }
        }

        void Reset()
        {
            _filterName = string.Empty;
            _filterCategory = "None";
            _filterModality = "None";
            _filterMovement = "None";
            _filterComplexity = "None";
            _filterInventory = "None";

            Filter();
        }
    }
}
