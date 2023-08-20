using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class ListArticlesComponent
    {
        [Parameter] public IEnumerable<Articles> ListOfItems { get; set; } = new List<Articles>();
    }
}
