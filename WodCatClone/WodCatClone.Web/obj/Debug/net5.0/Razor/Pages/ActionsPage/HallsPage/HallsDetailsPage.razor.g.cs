#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab9c31342059716e8b74d17cdf8aa42522b5bf4"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/gymboxs/{HallId:int}")]
    public partial class HallsDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WodCatClone.Web.PageComponents.HeaderComponent.HeaderComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col visualContainerId");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddAttribute(8, "style", "margin: 0 250px;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-6 text-left text-light pages p-0 mb-3");
            __builder.AddMarkupContent(11, "<a href=\"/\" class=\"link\">WODCAT</a> &rarr; \r\n                ");
            __builder.AddMarkupContent(12, "<a href=\"/gymboxs\" class=\"link\">Кроссфит залы</a> &rarr; ");
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(13, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, "<div class=\"col-6 text-right text-light pages p-0 mb-3\"><button class=\"btn text-white createHall\" @*@onclick=\"Add*@\">Редактировать</button></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "HallId");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-4");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "style", "background: white; width: 150px; height: 150px;");
            __builder.AddAttribute(26, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-8");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col");
            __builder.OpenElement(34, "h1");
            __builder.AddAttribute(35, "class", "h1Id");
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(36, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col");
            __builder.AddMarkupContent(42, "<img src=\"img/Ukraine.png\" style=\"width: 30px; height: 20px;\" class=\"mr-2\">\r\n                            ");
            __builder.OpenElement(43, "strong");
            __builder.AddAttribute(44, "style", "color: #333333;");
            __builder.AddMarkupContent(45, "Украина, ");
#nullable restore
#line 30 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(46, Hall.Town);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                     if (Hall.Rating is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col");
            __builder.OpenElement(51, "span");
            __builder.AddAttribute(52, "style", "color: #4caf50;");
#nullable restore
#line 37 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(53, Hall.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, " / 10");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.AddMarkupContent(56, "<div class=\"row\"><div class=\"col\"></div></div>\r\n            \r\n            ");
            __builder.AddMarkupContent(57, "<h3 class=\"h3Add\">Здесь вы можете добавить новый зал в каталог WODCAT</h3>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
