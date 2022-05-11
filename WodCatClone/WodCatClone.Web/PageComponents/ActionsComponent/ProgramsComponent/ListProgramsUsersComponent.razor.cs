using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class ListProgramsUsersComponent
    {
        [Parameter] public IEnumerable<User> ListOfItems { get; set; }
    }
}
