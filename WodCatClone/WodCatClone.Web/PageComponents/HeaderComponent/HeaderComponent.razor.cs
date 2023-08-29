using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class HeaderComponent
    {
        [Parameter] public User? User { get; set; } = new();
    }
}
