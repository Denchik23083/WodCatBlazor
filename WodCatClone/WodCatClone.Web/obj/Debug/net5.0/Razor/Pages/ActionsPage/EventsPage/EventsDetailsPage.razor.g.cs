#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f5c02389c16ce7d637c679942295b38a6ddf7a"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
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
using WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ProfileComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.MainComponent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/events/{EventId:int}")]
    public partial class EventsDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WodCatClone.Web.PageComponents.HeaderComponent.HeaderComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent.ConfirmRemoveEvent>(2);
            __builder.AddAttribute(3, "OnCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
              OnCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnShow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
            OnShow

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Event", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.Events>(
#nullable restore
#line 9 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
           Event

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "EventId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
             EventId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 6 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
          ConfirmRemoveEvent = (WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent.ConfirmRemoveEvent)__value;

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
            __builder.AddAttribute(12, "class", "col visualContainerEvent");
            __builder.AddAttribute(13, "style", "background-image:" + " url(/" + (
#nullable restore
#line 13 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                                         Image

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddAttribute(16, "style", "margin: 0 250px;");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-6 text-left text-light pages p-0 mb-3");
            __builder.AddMarkupContent(19, "<a href=\"/\" class=\"link\">WODCAT</a> &rarr; \r\n                ");
            __builder.AddMarkupContent(20, "<a href=\"/events\" class=\"link\">Мероприятия и Соревнования</a> &rarr; ");
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(21, Event.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
             if (User is not null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                 if (User.Id == Event.UserId)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-6 text-right text-light pages mb-3");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary text-white");
            __builder.AddAttribute(26, "style", "font-weight: bold;");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                      Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "Редактировать\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger text-white");
            __builder.AddAttribute(32, "style", "font-weight: bold;");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                      OnShow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n                            Удалить\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "EventId");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row mb-3");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-4");
            __builder.OpenElement(42, "img");
            __builder.AddAttribute(43, "src", 
#nullable restore
#line 42 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                               HallEmblem

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "style", "background: white; width: 200px; height: 200px;");
            __builder.AddAttribute(45, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-8");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col");
            __builder.OpenElement(53, "h1");
            __builder.AddAttribute(54, "class", "h1Id");
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(55, Event.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col");
            __builder.AddMarkupContent(61, "<img src=\"img/Ukraine.png\" style=\"width: 30px; height: 20px;\" class=\"mr-2\">\r\n                            ");
            __builder.OpenElement(62, "strong");
            __builder.AddAttribute(63, "style", "color: #333333;");
            __builder.AddMarkupContent(64, "Украина, ");
#nullable restore
#line 53 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(65, Event.Town);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                     if (Hall is not null && HallEmblem is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col mb-2");
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "src", 
#nullable restore
#line 60 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                           HallEmblem

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "width", "75");
            __builder.AddAttribute(73, "height", "75");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "href", "/gymboxs/" + (
#nullable restore
#line 61 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                   Hall.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "class", "link");
#nullable restore
#line 61 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(78, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "row");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col");
            __builder.OpenElement(83, "strong");
            __builder.AddAttribute(84, "style", "color: #333333;");
            __builder.AddMarkupContent(85, "Начало: ");
#nullable restore
#line 67 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(86, StartDate);

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, " ");
#nullable restore
#line 67 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(88, StartTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col");
            __builder.OpenElement(94, "strong");
            __builder.AddAttribute(95, "style", "color: #333333;");
            __builder.AddMarkupContent(96, "Завершение: ");
#nullable restore
#line 72 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(97, EndDate);

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, " ");
#nullable restore
#line 72 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(99, EndTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "row");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col");
            __builder.OpenElement(105, "strong");
            __builder.AddAttribute(106, "style", "color: #333333;");
            __builder.AddMarkupContent(107, "Регистрация до: ");
#nullable restore
#line 77 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(108, RegisterDate);

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, " ");
#nullable restore
#line 77 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(110, RegisterTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "row");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col p-3 mb-3");
            __builder.OpenElement(116, "strong");
            __builder.AddAttribute(117, "style", "color: #333333;");
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(118, Event.TypeEvent);

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, " ");
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
__builder.AddContent(120, Event.TypeSport);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
             if (IsLoginUser)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                 if (User!.EventId != Event.Id)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                     if (DateTime.Now < Event.RegisterDate)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "row mb-3");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "col");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "class", "joinHall");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                                   Join

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(128, "Регистрироваться");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(129, "<div class=\"row mb-3\"><div class=\"col\"><button class=\"joinHall\">Регистрация окончена</button></div></div>");
#nullable restore
#line 106 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                     
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                     if (DateTime.Now < Event.StartDate)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "row mb-3");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "col");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "class", "exitHall");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                                   Exit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(137, "Выйти");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(138, "<div class=\"row mb-3\"><div class=\"col\"><button class=\"exitHall\">Мероприятие началось</button></div></div>");
#nullable restore
#line 125 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "row");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "col p-3 footerEvent");
            __builder.AddAttribute(144, "style", "top: 695px;");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "row");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col text-center");
            __builder.OpenElement(149, "span");
            __builder.AddAttribute(150, "class", "programslink");
            __builder.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                     DisplayEvents

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(152, "О СОБЫТИИ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                ");
            __builder.OpenElement(154, "span");
            __builder.AddAttribute(155, "class", "programslink");
            __builder.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 136 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                     DisplayEventsWorkoutsExercises

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(157, "ЗАДАНИЕ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                ");
            __builder.OpenElement(159, "span");
            __builder.AddAttribute(160, "class", "programslink");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 137 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                     DisplayUsers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(162, "УЧАСТНИКОВ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 140 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
         if (DisplayEvent)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent.AboutEventComponent>(163);
            __builder.AddAttribute(164, "Event", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.Events>(
#nullable restore
#line 142 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                        Event

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 143 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
        }
        else if (DisplayEventWorkoutExercise)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.IndividualWorkoutsComponent>(165);
            __builder.AddAttribute(166, "Workout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.Workouts>(
#nullable restore
#line 146 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                  Workout

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 147 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
        }
        else if (DisplayUser)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent.ListEventsUsersComponent>(167);
            __builder.AddAttribute(168, "ListOfItems", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WodCatClone.Db.Entities.Auth.User>>(
#nullable restore
#line 150 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
                                                   Users

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 151 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\EventsPage\EventsDetailsPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
