#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197d15649a885f2d98ce6599f3c52da29fd6de1d"
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
using WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent;

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
using WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ProfileComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.MainComponent;

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
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent.ConfirmRemoveHall>(2);
            __builder.AddAttribute(3, "OnCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
              OnCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnShow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
            OnShow

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Hall", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.Halls>(
#nullable restore
#line 9 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
          Hall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "HallId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
            HallId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 6 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
          ConfirmRemoveHall = (WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent.ConfirmRemoveHall)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col visualContainerId");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddAttribute(15, "style", "margin: 0 250px;");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-6 text-left text-light pages p-0 mb-3");
            __builder.AddMarkupContent(18, "<a href=\"/\" class=\"link\">WODCAT</a> &rarr; \r\n                ");
            __builder.AddMarkupContent(19, "<a href=\"/gymboxs\" class=\"link\">Кроссфит залы</a> &rarr; ");
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(20, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
             if (User is not null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 if (User.Id == Hall.UserId)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-6 text-right text-light pages mb-3");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-primary text-white");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                                             Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "style", "font-weight: bold;");
            __builder.AddMarkupContent(27, "Редактировать");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-danger text-white");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                                            OnShow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "style", "font-weight: bold;");
            __builder.AddMarkupContent(33, "Удалить");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "HallId");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row mb-3");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-4");
            __builder.OpenElement(41, "img");
            __builder.AddAttribute(42, "src", 
#nullable restore
#line 33 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "style", "background: white; width: 200px; height: 200px;");
            __builder.AddAttribute(44, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-8");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col");
            __builder.OpenElement(52, "h1");
            __builder.AddAttribute(53, "class", "h1Id");
#nullable restore
#line 38 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(54, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col");
            __builder.AddMarkupContent(60, "<img src=\"img/Ukraine.png\" style=\"width: 30px; height: 20px;\" class=\"mr-2\">\r\n                            ");
            __builder.OpenElement(61, "strong");
            __builder.AddAttribute(62, "style", "color: #333333;");
            __builder.AddMarkupContent(63, "Украина, ");
#nullable restore
#line 44 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(64, Hall.Town);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                     if (Hall.Rating is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col");
            __builder.OpenElement(69, "span");
            __builder.AddAttribute(70, "style", "color: #4caf50;");
#nullable restore
#line 51 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(71, Hall.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, " / 10");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "row");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col p-3 mb-3");
            __builder.AddAttribute(78, "style", "font-size: 20px;line-height: 21px;font-weight: 500;");
#nullable restore
#line 59 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                     foreach (var item in Type)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(79, "span");
            __builder.AddAttribute(80, "style", "color: grey;");
#nullable restore
#line 61 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(81, item);

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, " ");
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col countAthletes text-white");
            __builder.AddAttribute(88, "style", "margin: 0 400px;");
#nullable restore
#line 67 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(89, Athlete);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.AddMarkupContent(91, "<div class=\"row mb-3\"><div class=\"col text-center\"><span class=\"athletes\">Атлетов</span></div></div>");
#nullable restore
#line 75 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
             if (IsLoginUser)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 if (User!.HallId != Hall.Id)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "row mb-3");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "col");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "class", "joinHall");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                               Join

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(99, "Присоединиться");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row mb-3");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "class", "exitHall");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                                               Exit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(107, "Выйти");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "<div class=\"row mb-3\"><div class=\"col text-center\"><strong style=\"color: #333333;\">Whiteboard</strong></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "row");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "col" + " footerHall" + " " + (
#nullable restore
#line 103 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
                                Top

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "footerLocation");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "row");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "col-6");
            __builder.AddMarkupContent(120, "<div class=\"row\"><div class=\"col\"><img src=\"img/location-bg.png\" width=\"100\" height=\"150\"></div></div>\r\n                    ");
            __builder.AddMarkupContent(121, "<div class=\"row\"><div class=\"col\"><h1 class=\"location\">Локация</h1></div></div>\r\n                    ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "row");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "col");
            __builder.OpenElement(126, "strong");
            __builder.AddAttribute(127, "style", "color: white;");
            __builder.AddMarkupContent(128, "Украина, ");
#nullable restore
#line 119 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(129, Hall.Town);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "row");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col");
            __builder.OpenElement(135, "span");
            __builder.AddAttribute(136, "style", "color: #bdc1c6;");
#nullable restore
#line 124 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(137, Hall.Location);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "col-6");
            __builder.AddMarkupContent(141, "<div class=\"row\"><div class=\"col\"><img src=\"img/members-bg.png\" width=\"100\" height=\"150\"></div></div>\r\n                    ");
            __builder.AddMarkupContent(142, "<div class=\"row\"><div class=\"col\"><h1 class=\"location\">Атлетов</h1></div></div>\r\n                    ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "row");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "col");
            __builder.OpenElement(147, "strong");
            __builder.AddAttribute(148, "style", "color: white;");
#nullable restore
#line 141 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\HallsPage\HallsDetailsPage.razor"
__builder.AddContent(149, Hall.Athletes);

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
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
