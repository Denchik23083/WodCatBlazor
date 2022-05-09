using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsComponent
    {
        [Parameter] public Programs Programs { get; set; }

        string _url = string.Empty;

        protected override void OnInitialized()
        {
            _url = $"programs/{Programs.Id}";
        }
    }
}
