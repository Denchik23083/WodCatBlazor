#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2a0b7ce8945b5d961b555dd68febec10c386050"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
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
    public partial class StartWorkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
 if (DisplayStartWorkout)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModal");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display: block");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog StartDialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content StartDialogContent");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddAttribute(16, "style", "border: 0;");
            __builder.OpenElement(17, "h5");
            __builder.AddAttribute(18, "class", "modal-title timerInfo");
            __builder.AddMarkupContent(19, "\r\n                        На время: ");
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
__builder.AddContent(20, Workout.Time);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "close");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                                    OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "type", "button");
            __builder.AddMarkupContent(26, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col");
            __builder.AddMarkupContent(32, "<h5 class=\"timerInfo p-3\">Упражнения:</h5>\r\n                        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "p-3");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent.ListWorkoutsExercisesComponent>(35);
            __builder.AddAttribute(36, "ListOfItems", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WodCatClone.Db.Entities.Actions.WorkoutsExercises>>(
#nullable restore
#line 28 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                             WorkoutsExercises

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "IsLink", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                        false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "Color", "#fff");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal-body text-center");
            __builder.AddAttribute(42, "style", "border: 0;");
            __builder.OpenElement(43, "h1");
            __builder.AddAttribute(44, "class", "time");
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
__builder.AddContent(45, _minutes);

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, " : ");
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
__builder.AddContent(47, _seconds);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "<br>");
#nullable restore
#line 37 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                     if (IsShowStart)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                      StartTimer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "class", "btn btn-success pl-3 pr-3 pt-2 pb-2 button");
            __builder.AddMarkupContent(52, "Start\r\n                        ");
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                      Continue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "btn btn-success pl-3 pr-3 pt-2 pb-2 button");
            __builder.AddMarkupContent(56, "Continue\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                      Stop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "class", "btn btn-warning pl-3 pr-3 pt-2 pb-2 button");
            __builder.AddMarkupContent(61, "Stop\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                                      Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "class", "btn btn-danger pl-3 pr-3 pt-2 pb-2 button");
            __builder.AddMarkupContent(66, "Reset\r\n                        ");
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\WorkoutsComponent\StartWorkout.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
