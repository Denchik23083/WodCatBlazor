using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class IndividualRatingsComponent
    {
        [Parameter] public User User { get; set; }
    }
}
