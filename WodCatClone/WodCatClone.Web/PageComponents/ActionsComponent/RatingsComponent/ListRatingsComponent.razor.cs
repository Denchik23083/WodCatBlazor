using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class ListRatingsComponent
    {
        [Parameter] public IEnumerable<User> ListOfItems { get; set; } = new List<User>();

        public int Position = 1;

        protected override void OnInitialized()
        {
            Position = 1;
        }

        protected override void OnParametersSet()
        {
            Position = 1;
        }
    }
}
