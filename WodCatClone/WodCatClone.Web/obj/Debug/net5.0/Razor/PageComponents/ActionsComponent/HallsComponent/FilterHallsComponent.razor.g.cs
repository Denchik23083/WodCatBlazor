#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225be8070db25b63a942fd72981de14dff9362ac"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
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
    public partial class FilterHallsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-3 p-0 pr-1");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "d-inline filterHalls pt-2 pb-2");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                                                              _filterTown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filterTown = __value, _filterTown));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", "None");
            __builder.AddMarkupContent(10, "Город");
            __builder.CloseElement();
#nullable restore
#line 5 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
             foreach (var item in FilterTown)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                                item.Filter

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
__builder.AddContent(13, item.Content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-3 p-0 pr-1");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "class", "d-inline filterHalls pt-2 pb-2");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                                                              _filterType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filterType = __value, _filterType));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "None");
            __builder.AddMarkupContent(23, "Тип");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
             foreach (var item in FilterType)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", 
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                                item.Filter

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
__builder.AddContent(26, item.Content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-3 p-0 pr-1");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-primary form-control mb-2");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                      Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n            Search\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-3 p-0");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-danger form-control mb-2");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                      Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n            Reset\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n    ");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent.ListHallsComponent>(44);
            __builder.AddAttribute(45, "ListOfItems", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WodCatClone.Db.Entities.Actions.Halls>>(
#nullable restore
#line 37 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\FilterHallsComponent.razor"
                                     Halls

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
