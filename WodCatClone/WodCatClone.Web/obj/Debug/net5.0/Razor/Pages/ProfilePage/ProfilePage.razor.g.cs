#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda6e92eeb2468aacf940af0c2c1850541ed64dc"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.Pages.ProfilePage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile/{NickName}")]
    public partial class ProfilePage : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddAttribute(5, "class", "col visualContainerProfile");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddAttribute(8, "style", "margin: 0 250px;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-6 text-left text-light pages p-0 mb-3");
            __builder.AddMarkupContent(11, "<a href=\"/\" class=\"link\">WODCAT</a> &rarr; \r\n                Профиль &rarr; ");
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(12, User.NickName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
             if (IsEnterUser && IsLoginUser)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-6 text-right text-light pages mb-3");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary text-white");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                                                         Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "style", "font-weight: bold;");
            __builder.AddMarkupContent(19, "Редактировать");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "ProfileId");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row mb-3");
            __builder.AddMarkupContent(25, "<div class=\"col-3\"></div>\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-3");
#nullable restore
#line 23 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                     if (Image is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "src", 
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                   Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "style", "width: 200px; height: 200px;");
            __builder.AddAttribute(31, "alt");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-6");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col mb-2 text-left");
            __builder.OpenElement(39, "h2");
            __builder.AddAttribute(40, "style", "font-size: 30px; font-weight: 700; margin: 10px 0; color: #161521;");
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(41, User.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, " ");
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(43, User.Surname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col mb-2 text-left");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "style", "color: #161521;");
#nullable restore
#line 38 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(51, Age);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "&nbsp;лет");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col mb-2 text-left");
            __builder.AddMarkupContent(58, "<img src=\"img/Ukraine.png\" style=\"width: 30px; height: 20px;\" class=\"mr-2\">\r\n                            ");
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "style", "color: #161521;");
#nullable restore
#line 44 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(61, User.Town);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, " Украина");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                     if (Hall is not null && HallEmblem is not null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col mb-2 text-left");
            __builder.OpenElement(67, "img");
            __builder.AddAttribute(68, "src", 
#nullable restore
#line 51 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                           HallEmblem

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "width", "75");
            __builder.AddAttribute(70, "height", "75");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.OpenElement(72, "a");
            __builder.AddAttribute(73, "href", "/gymboxs/" + (
#nullable restore
#line 52 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                                   Hall.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "class", "link");
#nullable restore
#line 52 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(75, Hall.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col mb-2 text-left");
            __builder.AddMarkupContent(80, "<i class=\"fa-solid fa-coins\" style=\"color: #9f9ea3;\"></i>\r\n                            ");
            __builder.OpenElement(81, "span");
            __builder.AddAttribute(82, "style", "color: #161521;");
#nullable restore
#line 59 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(83, User.Points);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(84, " баллов");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "row");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col footerHall userTop");
            __builder.AddAttribute(90, "style", "color: #bdc1c6;");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "p-3");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row p-3");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "col");
            __builder.AddMarkupContent(97, "<strong class=\"mr-2\">Рост:</strong>");
#nullable restore
#line 73 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                     if (User.Height is not null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(98, User.Height);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                    
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row p-3");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col");
            __builder.AddMarkupContent(104, "<strong class=\"mr-2\">Вес:</strong>");
#nullable restore
#line 82 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                     if (User.Weight is not null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(105, User.Weight);

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                    
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "row p-3");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "col");
            __builder.AddMarkupContent(111, "<strong class=\"mr-2\">О себе:</strong>");
#nullable restore
#line 91 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                     if (User.AboutMe is not null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
__builder.AddContent(112, User.AboutMe);

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ProfilePage\ProfilePage.razor"
                                     
                    }

#line default
#line hidden
#nullable disable
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
