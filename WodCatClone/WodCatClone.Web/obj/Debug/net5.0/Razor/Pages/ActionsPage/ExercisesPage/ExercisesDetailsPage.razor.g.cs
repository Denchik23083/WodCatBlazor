#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a5674e871842dd9a1c5339c4fd5a6bde0364b2"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/exercises/{ExerciseId:int}")]
    public partial class ExercisesDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WodCatClone.Web.PageComponents.HeaderComponent.HeaderComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "wrapperId");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row mb-2");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col text-left text-light pages");
            __builder.AddMarkupContent(8, "<a href=\"/\" class=\"link\">WODCAT</a>&nbsp;&rarr;&nbsp;\r\n            ");
            __builder.AddMarkupContent(9, "<a href=\"/exercises\" class=\"link\">Упражнения</a>&nbsp;&rarr;&nbsp;\r\n            ");
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(10, Exercise.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row mb-2");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "NameId");
#nullable restore
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(18, Exercise.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "cubId");
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(22, Exercise.Modality);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "greenCub");
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(26, Exercise.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row mb-2");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-6");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "exercisesId p-2");
            __builder.OpenElement(34, "span");
            __builder.AddMarkupContent(35, "Сложность: ");
#nullable restore
#line 23 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(36, Exercise.Complexity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "<br><br>\r\n                ");
            __builder.OpenElement(38, "span");
#nullable restore
#line 24 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(39, Exercise.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "<br><br>");
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
                 if (Exercise.Inventory is not "Нет")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "span");
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(42, Exercise.Inventory);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "<br><br>");
#nullable restore
#line 28 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-6");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "text-center exercisesId p-2");
            __builder.OpenElement(49, "iframe");
            __builder.AddAttribute(50, "width", "600");
            __builder.AddAttribute(51, "height", "300");
            __builder.AddAttribute(52, "src", 
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
                          Exercise.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(53, "frameborder", "0");
            __builder.AddAttribute(54, "allow", "accelerometer;autoplay;clipboard-write;encrypted-media;gyroscope;picture-in-picture");
            __builder.AddAttribute(55, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.AddMarkupContent(57, "<div class=\"row\"><div class=\"col\"><h2 class=\"NameId\">Описание</h2>\r\n            <hr class=\"hr\"></div></div>\r\n    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "class", "full");
#nullable restore
#line 52 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ExercisesPage\ExercisesDetailsPage.razor"
__builder.AddContent(64, Exercise.FullDescription);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
