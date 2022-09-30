using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Web.Utilities;

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

        public Halls Hall { get; set; }

        public bool IsShow { get; set; } = false;

        public bool IsBadEmblem { get; set; } = false;

        public string Image = "None";

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
            new() { Content = "Запорожье", Filter = "Запорожье" },
            new() { Content = "Львов", Filter = "Львов" },
        };

        public List<HallRating> HallRating = new()
        {
            new() { Content = "0.5", Value = "0.5" },
            new() { Content = "1.0", Value = "1.0" },
            new() { Content = "1.5", Value = "1.5" },
            new() { Content = "2.0", Value = "2.0" },
            new() { Content = "2.5", Value = "2.5" },
            new() { Content = "3.0", Value = "3.0" },
            new() { Content = "3.5", Value = "3.5" },
            new() { Content = "4.0", Value = "4.0" },
            new() { Content = "4.5", Value = "4.5" },
            new() { Content = "5.0", Value = "5.0" },
            new() { Content = "5.5", Value = "5.5" },
            new() { Content = "6.0", Value = "6.0" },
            new() { Content = "6.5", Value = "6.5" },
            new() { Content = "7.0", Value = "7.0" },
            new() { Content = "7.5", Value = "7.5" },
            new() { Content = "8.0", Value = "8.0" },
            new() { Content = "8.5", Value = "8.5" },
            new() { Content = "9.0", Value = "9.0" },
            new() { Content = "9.5", Value = "9.5" },
            new() { Content = "10.0", Value = "10.0" }
        };

        protected override void OnInitialized()
        {
            if (HallId == 0)
            {
                Hall = new Halls();
            }
            else
            {
                Hall = HallsService.GetHall(HallId);
                SelectedType = Hall.Type.Split(",").ToList();
                foreach (var selectedType in SelectedType)
                {
                    var item = HallTypes.FirstOrDefault(b => b.Value.Equals(selectedType));
                    HallTypes.Remove(item);
                }

                Image = HallsService.GetImage(Hall.EmblemHallId);
            }

            HallEmblem = HallsService.GetAllHallEmblem();
        }

        public void Submit()
        {
            var isValid = Validation();

            if (isValid)
            {
                ConvertSelectedTypes();
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
        }

        private bool Validation()
        {
            if (Image is not "None")
            {
                IsBadEmblem = false;
            }
            else
            {
                IsBadEmblem = true;
                return false;
            }

            return true;
        }

        public void AddHallType(string selected)
        {
            SelectedType.Add(selected);

            var item = HallTypes.FirstOrDefault(b => b.Value.Equals(selected));

            HallTypes.Remove(item);
        }

        public void RemoveSelectedType(string item)
        {
            SelectedType.Remove(item);

            HallTypes.Add(new() { Content = item, Value = item });
        }

        public void ConvertSelectedTypes()
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
        }

        public void SelectedImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            Image = selected;
            
            var hallEmblem = HallEmblem.FirstOrDefault(b => b.Image.Equals(selected));

            Hall.EmblemHallId = hallEmblem?.Id;
        }
    }
}
