using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class IndividualArticlesComponent
    {
        [Parameter] public Exercises Exercises { get; set; }

        string _url = string.Empty;

        protected override void OnInitialized()
        {
            _url = $"exercises/{Exercises.Id}";
        }
    }
}
