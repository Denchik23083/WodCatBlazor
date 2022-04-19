using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class ListRatingsComponent
    {
        [Parameter] public IEnumerable<User> ListOfItems { get; set; }
    }
}
