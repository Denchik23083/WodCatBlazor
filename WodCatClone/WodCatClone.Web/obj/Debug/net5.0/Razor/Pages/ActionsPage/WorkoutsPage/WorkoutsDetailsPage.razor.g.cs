#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f020effa1db5e770634c397e1b41f4aeeb9de9fc"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/workouts/{WorkoutId:int}")]
    public partial class WorkoutsDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(9, "<a href=\"/workouts\" class=\"link\">КросcФит Тренировки (WOD)</a>&nbsp;&rarr;&nbsp;\r\n            ");
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(10, Workout.Name);

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
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(18, Workout.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "cub");
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(22, Workout.Modality);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "greenCub");
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(26, Workout.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, " / 10");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddMarkupContent(29, "<span class=\"greenCub\">Рекомендуется</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    \r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row p-3 mb-2");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-4 pl-0");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "workoutsId p-3");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col");
            __builder.OpenElement(41, "span");
            __builder.AddMarkupContent(42, "На время:<br>");
#nullable restore
#line 28 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                             foreach (var item in WorkoutExercises)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(43, item);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<br>");
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "<br>\r\n                        ");
            __builder.OpenElement(46, "span");
            __builder.AddAttribute(47, "class", "workoutsTimeId");
            __builder.AddMarkupContent(48, "\r\n                            Время ");
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(49, Workout.Minutes);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "<span>m</span>:");
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
__builder.AddContent(51, Workout.Seconds);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<span>s</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col text-center");
            __builder.OpenElement(58, "img");
            __builder.AddAttribute(59, "src", 
#nullable restore
#line 41 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                   Workout.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "alt", "Image");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<div class=\"row\"><div class=\"col p-3 text-right\"><button class=\"btn btn-primary\">Старт</button></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-8");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "workoutsId p-3");
#nullable restore
#line 53 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                 if (IsLogin)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.ResultWorkoutsComponent>(68);
            __builder.AddAttribute(69, "WorkoutId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                                        WorkoutId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.DeleteResult>(71);
            __builder.AddAttribute(72, "OnDelete", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 57 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                                OnDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(73, "OnCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 58 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                                OnCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 56 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                        DeleteResult = (WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.DeleteResult)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 60 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<div class=\"row\"><div class=\"col\"><h1>You need login!</h1></div></div>");
#nullable restore
#line 68 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    \r\n    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row p-3 mb-2");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col pl-0");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.GetAllResultWorkouts>(81);
            __builder.AddAttribute(82, "WorkoutId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 75 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                             WorkoutId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "IsDisplayDialog", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 75 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\WorkoutsPage\WorkoutsDetailsPage.razor"
                                                                         IsDisplayDialog

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
