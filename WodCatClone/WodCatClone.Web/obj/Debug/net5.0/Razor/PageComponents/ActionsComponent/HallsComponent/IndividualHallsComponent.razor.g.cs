#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b61280e2489fe0d48c0743aa4863ecaef896de2"
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
    public partial class IndividualHallsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "halls mb-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-3");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 4 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                       Halls.Emblem

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "style", "width: 250px; height: 300px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-9 p-3");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col mb-2");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "Name mr-2");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 9 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                                                _url

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "bold");
#nullable restore
#line 9 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
__builder.AddContent(21, Halls.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                     if (Halls.Rating is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "class", "greenCub");
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
__builder.AddContent(24, Halls.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, " / 10");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col mb-2");
#nullable restore
#line 18 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                     foreach (var item in HallsType)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
__builder.AddContent(31, item);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                             
                        if (value < HallsType.Length - 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<span>&nbsp;|&nbsp;</span>");
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
                            value++;
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
             if (Halls.Description is not null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col mb-2");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "pr-3");
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
__builder.AddContent(39, Halls.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col");
            __builder.AddMarkupContent(44, "<img src=\"img/Ukraine.png\" style=\"width: 30px; height: 20px;\" class=\"mr-2\">\r\n                    ");
            __builder.OpenElement(45, "strong");
            __builder.AddAttribute(46, "style", "color: #a3a2ab;");
            __builder.AddMarkupContent(47, "Украина, ");
#nullable restore
#line 44 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\IndividualHallsComponent.razor"
__builder.AddContent(48, Halls.Location);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591