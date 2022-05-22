using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class AddEditHallComponent
    {
        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Parameter] public bool Edit { get; set; }

        [Parameter] public bool Add { get; set; }

        [Parameter] public int HallId { get; set; }

        public IEnumerable<HallEmblem> HallEmblem { get; set; }

        public Halls Hall = new();

        public bool IsDisplaySubmitButton { get; set; } = false;

        public bool IsImage { get; set; } = false;

        public bool IsTown { get; set; } = false;

        public bool IsShow { get; set; } = false;

        public string _image = "None";

        public int Value { get; set; }

        public List<string> SelectedType = new();

        public List<HallTypes> HallTypes = new()
        {
            new() { Content = "Affiliate Crossfit", Value = "Affiliate Crossfit" },
            new() { Content = "Boxing", Value = "Boxing" },
            new() { Content = "Crossfit (not Aff.)", Value = "Crossfit (not Aff.)" },
            new() { Content = "Fitness", Value = "Fitness" },
            new() { Content = "Gym Crossfit", Value = "Gym" },
            new() { Content = "MMA", Value = "MMA" },
            new() { Content = "Weightlifting", Value = "Weightlifting" },
            new() { Content = "Yoga", Value = "Yoga" },
        };

        public List<FilterHalls> Town = new()
        {
            new() { Content = "Херсон", Filter = "Херсон" },
            new() { Content = "Киев", Filter = "Киев" },
            new() { Content = "Харьков", Filter = "Харьков" },
            new() { Content = "Николаев", Filter = "Николаев" },
            new() { Content = "Одесса", Filter = "Одесса" },
            new() { Content = "Черновцы", Filter = "Черновцы" },
            new() { Content = "Днепр", Filter = "Днепр" },
            new() { Content = "Хмельницкий", Filter = "Хмельницкий" },
            new() { Content = "Кривой Рог", Filter = "Кривой Рог" },
            new() { Content = "Львов", Filter = "Львов" },
        };

        protected override void OnInitialized()
        {
            HallEmblem = HallsService.GetAllHallEmblem();
        }

        public void AddHallType(string selected)
        {
            SelectedType.Add(selected);

            var item = HallTypes.FirstOrDefault(b => b.Value == selected);

            HallTypes.Remove(item);
        }

        public void Submit()
        {
            foreach (var item in SelectedType)
            {
                if (Value == 0)
                {
                    Hall.Type = $"{item}";
                    Value++;
                }
                else
                {
                    Hall.Type += $",{item}";
                }
            }

            if (Add)
            {
                var result = HallsService.AddHall(Hall);

                NavigationManager.NavigateTo(result ? "/gymboxs" : "/gymboxs/add");
            }

            if (Edit)
            {
                var result = HallsService.EditHall(Hall, HallId);

                NavigationManager.NavigateTo(result ? $"/gymboxs/{HallId}" : $"/gymboxs/{HallId}/edit");
            }
        }

        public void RemoveSelectedType(string item)
        {
            SelectedType.Remove(item);

            HallTypes.Add(new() { Content = item, Value = item });
        }

        public void Image(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            if (selected == "None")
            {
                IsDisplaySubmitButton = false;
                IsImage = false;
            }

            var hallEmblem = HallEmblem.FirstOrDefault(b => b.Image == selected);

            _image = selected;

            if (hallEmblem is not null)
            {
                Hall.EmblemHallId = hallEmblem.Id;
                IsImage = true;
            }

            if (IsTown && IsImage)
            {
                IsDisplaySubmitButton = true;
            }
        }

        public void TownValue(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            if (selected == "None")
            {
                IsDisplaySubmitButton = false;
                IsTown = false;
            }
            else
            {
                IsTown = true;
                Hall.Town = selected;
            }

            if (IsTown && IsImage)
            {
                IsDisplaySubmitButton = true;
            }
        }
    }
}
