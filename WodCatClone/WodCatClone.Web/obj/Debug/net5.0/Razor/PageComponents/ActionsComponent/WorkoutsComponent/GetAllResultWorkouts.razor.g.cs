#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11a355074729751dbbfebc6a70eec9eeca502bc0"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.Pages.MainPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Logic.ActionsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Db.Entities.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.HeaderComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ProfileComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.MainComponent;

#line default
#line hidden
#nullable disable
    public partial class GetAllResultWorkouts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
 if (User is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h2");
            __builder.AddAttribute(1, "class", "text-white");
#nullable restore
#line 3 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
__builder.AddContent(2, ResultWorkouts.Count());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, " результатов");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    <hr class=\"hr\">\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-borderless");
            __builder.AddMarkupContent(7, @"<thead><tr class=""tableheader""><th scope=""col"">Имя</th>
            <th scope=""col"">Время</th>
            <th scope=""col"">Повт.</th>
            <th scope=""col"">Страна</th>
            <th scope=""col"">Город</th>
            <th scope=""col"">Дата</th>
            <th scope=""col"">Увлекательность</th>
            <th scope=""col"">Нагрузка</th></tr></thead>");
#nullable restore
#line 18 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
         foreach (var item in ResultWorkouts)
        {
            if (item.UserId == User.Id)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tbody");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
                                 IsDisplayDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "class", "displayDialog");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
                                                        () => PostId(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.IndividualResultWorkouts>(13);
            __builder.AddAttribute(14, "ResultWorkout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.ResultWorkouts>(
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
                                                                 item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tbody");
            __builder.OpenElement(16, "tr");
            __builder.AddAttribute(17, "class", "displayDialog");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.IndividualResultWorkouts>(18);
            __builder.AddAttribute(19, "ResultWorkout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.ResultWorkouts>(
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
                                                                 item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\GetAllResultWorkouts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
