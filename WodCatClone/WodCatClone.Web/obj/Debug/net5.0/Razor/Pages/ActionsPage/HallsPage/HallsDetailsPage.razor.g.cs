#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9dea1bda78cf4b82fd9f2606d037ce675628f7"
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
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
             if (User is not null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 if (User.Id == Hall.UserId)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-6 text-right text-light pages p-0 mb-3");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn text-white createHall");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                                            Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "Редактировать");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "HallId");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row mb-3");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-4");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "src", 
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "style", "background: white; width: 150px; height: 200px;");
            __builder.AddAttribute(30, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-8");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col");
            __builder.OpenElement(38, "h1");
            __builder.AddAttribute(39, "class", "h1Id");
#nullable restore
#line 30 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(40, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col");
            __builder.AddMarkupContent(46, "<img src=\"img/Ukraine.png\" style=\"width: 30px; height: 20px;\" class=\"mr-2\">\r\n                            ");
            __builder.OpenElement(47, "strong");
            __builder.AddAttribute(48, "style", "color: #333333;");
            __builder.AddMarkupContent(49, "Украина, ");
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(50, Hall.Town);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                     if (Hall.Rating is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col");
            __builder.OpenElement(55, "span");
            __builder.AddAttribute(56, "style", "color: #4caf50;");
#nullable restore
#line 43 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(57, Hall.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, " / 10");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col p-3 mb-3");
            __builder.AddAttribute(64, "style", "font-size: 20px;line-height: 21px;font-weight: 500;");
#nullable restore
#line 51 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                     foreach (var item in Type)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "span");
            __builder.AddAttribute(66, "style", "color: grey;");
#nullable restore
#line 53 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(67, item);

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, " ");
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col countAthletes");
            __builder.AddAttribute(74, "style", "margin: 0 400px;");
#nullable restore
#line 59 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(75, Hall.Athletes);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.AddMarkupContent(77, "<div class=\"row mb-3\"><div class=\"col text-center\"><span class=\"athletes\">Атлетов</span></div></div>");
#nullable restore
#line 67 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
             if (IsLoginUser)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 if (User!.HallId != Hall.Id)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row mb-3");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "joinHall");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                               Join

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(85, "Присоединиться");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "row mb-3");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "exitHall");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                               Exit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "Выйти");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "<div class=\"row mb-3\"><div class=\"col text-center\"><strong style=\"color: #333333;\">Whiteboard</strong></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col" + " footerHall" + " " + (
#nullable restore
#line 94 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                    Top

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "footerLocation");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "row");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "col-6");
            __builder.AddMarkupContent(106, "<div class=\"row\"><div class=\"col\"><img src=\"img/location-bg.png\" width=\"100\" height=\"150\"></div></div>\r\n                        ");
            __builder.AddMarkupContent(107, "<div class=\"row\"><div class=\"col\"><h1 class=\"location\">Локация</h1></div></div>\r\n                        ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "row");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col");
            __builder.OpenElement(112, "strong");
            __builder.AddAttribute(113, "style", "color: #333333;");
            __builder.AddMarkupContent(114, "Украина, ");
#nullable restore
#line 110 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(115, Hall.Town);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "row");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col");
            __builder.OpenElement(121, "span");
            __builder.AddAttribute(122, "style", "color: #bdc1c6;");
#nullable restore
#line 115 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(123, Hall.Location);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "col-6");
            __builder.AddMarkupContent(127, "<div class=\"row\"><div class=\"col\"><img src=\"img/members-bg.png\" width=\"100\" height=\"150\"></div></div>\r\n                        ");
            __builder.AddMarkupContent(128, "<div class=\"row\"><div class=\"col\"><h1 class=\"location\">Атлетов</h1></div></div>\r\n                        ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "row");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "col");
            __builder.OpenElement(133, "strong");
            __builder.AddAttribute(134, "style", "color: #333333;");
#nullable restore
#line 132 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(135, Hall.Athletes);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
