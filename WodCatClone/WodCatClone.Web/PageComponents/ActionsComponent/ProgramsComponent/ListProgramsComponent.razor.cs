using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class ListProgramsComponent
    {
        [Parameter] public IEnumerable<Programs> ListOfItems { get; set; }
    }
}
