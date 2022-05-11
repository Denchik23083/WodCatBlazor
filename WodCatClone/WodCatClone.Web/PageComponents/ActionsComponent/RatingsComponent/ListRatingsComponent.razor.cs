using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class ListRatingsComponent
    {
        [Parameter] public IEnumerable<User> ListOfItems { get; set; }

        public int Position = 1;

        protected override void OnAfterRender(bool firstRender)
        {
            Position = 1;
        }
    }
}
