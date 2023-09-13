using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent
{
    public partial class FilterExercisesComponent
    {
        [Parameter] public IEnumerable<Exercises> Exercises { get; set; } = new List<Exercises>();

        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        private string _filterModality = "None";
        private string _filterMovement = "None";
        private string _filterComplexity = "None";
        private string _filterInventory = "None";

        public List<FilterExercises> FilterModality = new()
        {
            new() { Content = "G", Filter = "G" },
            new() { Content = "W", Filter = "W" },
            new() { Content = "M", Filter = "M" },
        };

        public List<FilterExercises> FilterMovement = new()
        {
            new() { Content = "Бег", Filter = "Бег" },
            new() { Content = "Выход на кольцах", Filter = "Выход на кольцах" },
            new() { Content = "Выбросы", Filter = "Выбросы" },
            new() { Content = "Бёрпи", Filter = "Бёрпи" },
            new() { Content = "Отжимания", Filter = "Отжимания" },
            new() { Content = "Прыжки", Filter = "Прыжки" },
            new() { Content = "Пресс", Filter = "Пресс" },
            new() { Content = "Прыжки на скакалке", Filter = "Прыжки на скакалке" },
            new() { Content = "Брусья", Filter = "Брусья" },
            new() { Content = "Подтягивание", Filter = "Подтягивание" },
        };

        public List<FilterExercises> FilterComplexity = new()
        {
            new() { Content = "Легкий", Filter = "Легкий" },
            new() { Content = "Нормальный", Filter = "Нормальный" },
            new() { Content = "Сложный", Filter = "Сложный" },
        };

        public List<FilterExercises> FilterInventory = new()
        {
            new() { Content = "Нет", Filter = "Нет" },
            new() { Content = "Кольца гимнастические", Filter = "Кольца гимнастические" },
            new() { Content = "Штанга", Filter = "Штанга" },
            new() { Content = "Ящик для прыжков", Filter = "Ящик для прыжков" },
            new() { Content = "Скакалка", Filter = "Скакалка" },
            new() { Content = "Тренажер GHD", Filter = "Тренажер GHD" },
            new() { Content = "Кроссфит стойка", Filter = "Кроссфит стойка" },
    };

        public async Task Filter()
        {
            Exercises = await ExercisesService.GetAllExercisesAsync();

            if (_filterModality != "None")
            {
                Exercises = Exercises.Where(b => b.Modality!.Equals(_filterModality)).ToList();
            }
            if (_filterMovement != "None")
            {
                Exercises = Exercises.Where(b => b.Movement!.Equals(_filterMovement)).ToList();
            }
            if (_filterComplexity != "None")
            {
                Exercises = Exercises.Where(b => b.Complexity!.Equals(_filterComplexity)).ToList();
            }
            if (_filterInventory != "None")
            {
                Exercises = Exercises.Where(b => b.Inventory!.Equals(_filterInventory)).ToList();
            }
        }

        public async Task Reset()
        {
            _filterModality = "None";
            _filterMovement = "None";
            _filterComplexity = "None";
            _filterInventory = "None";

            await Filter();
        }
    }
}
