#pragma checksum "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bb2e114bfd0c0e002fe50336fcb3d10e7ca428f"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.Pages.MainPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Logic.ActionsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Db.Entities.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.HeaderComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent;

#line default
#line hidden
#nullable disable
    public partial class IndividualExercisesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "exercises mb-3 ml-3 p-2 pt-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row ml-1 mt-3 mr-1 mb-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "class", "Name");
            __builder.AddAttribute(8, "href", 
#nullable restore
#line 4 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
                                   _url

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 4 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
__builder.AddContent(9, Exercises.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "cub");
#nullable restore
#line 5 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
__builder.AddContent(13, Exercises.Modality);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row ml-1 mt-3 mr-1 mb-3");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-6");
#nullable restore
#line 11 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
__builder.AddContent(19, Exercises.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-6");
            __builder.OpenElement(23, "iframe");
            __builder.AddAttribute(24, "width", "600");
            __builder.AddAttribute(25, "height", "300");
            __builder.AddAttribute(26, "src", 
#nullable restore
#line 17 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
                      Exercises.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "frameborder", "0");
            __builder.AddAttribute(28, "allow", "accelerometer;autoplay;clipboard-write;encrypted-media;gyroscope;picture-in-picture");
            __builder.AddAttribute(29, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row  ml-1 mt-3 mr-1 mb-3");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-4 text-left");
            __builder.OpenElement(35, "span");
            __builder.AddMarkupContent(36, "Сложность: ");
#nullable restore
#line 27 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
__builder.AddContent(37, Exercises.Complexity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-4 text-center");
            __builder.OpenElement(41, "span");
            __builder.AddMarkupContent(42, "Движения: ");
#nullable restore
#line 31 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
__builder.AddContent(43, Exercises.Movement);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-4 text-right");
            __builder.OpenElement(47, "span");
            __builder.AddMarkupContent(48, "Инвентарь: ");
#nullable restore
#line 35 "C:\Users\User\source\repos\BlazorFinal\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ExercisesComponent\IndividualExercisesComponent.razor"
__builder.AddContent(49, Exercises.Inventory);

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
