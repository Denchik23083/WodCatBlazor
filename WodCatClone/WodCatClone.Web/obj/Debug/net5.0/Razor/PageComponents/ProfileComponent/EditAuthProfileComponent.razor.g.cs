#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d3d7a3c1902de75d96b5890b3f49afe7bbddf9"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ProfileComponent
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
    public partial class EditAuthProfileComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-6");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col mb-2");
#nullable restore
#line 5 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                 if (Image is not null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt");
            __builder.AddAttribute(11, "width", "150");
            __builder.AddAttribute(12, "height", "150");
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-6");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col mb-2");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
            __builder.AddAttribute(21, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                                 AuthUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                                                          Auth

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "row");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "selectedFormResult mb-2 mr-2");
                __builder2.AddAttribute(34, "placeholder", "Ник");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                                             AuthUser.NickName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AuthUser.NickName = __value, AuthUser.NickName))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AuthUser.NickName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "class", "selectedFormResult mb-2 mr-2");
                __builder2.AddAttribute(45, "placeholder", "E-mail");
                __builder2.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                                             AuthUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AuthUser.Email = __value, AuthUser.Email))));
                __builder2.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AuthUser.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "row");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "type", "password");
                __builder2.AddAttribute(56, "class", "selectedFormResult mb-2 mr-2");
                __builder2.AddAttribute(57, "placeholder", "Пароль");
                __builder2.AddAttribute(58, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                                             AuthUser.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AuthUser.Password = __value, AuthUser.Password))));
                __builder2.AddAttribute(60, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AuthUser.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "row");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "type", "password");
                __builder2.AddAttribute(68, "class", "selectedFormResult mb-2 mr-2");
                __builder2.AddAttribute(69, "placeholder", "Подтвердить Пароль");
                __builder2.AddAttribute(70, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ProfileComponent\EditAuthProfileComponent.razor"
                                             AuthUser.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AuthUser.ConfirmPassword = __value, AuthUser.ConfirmPassword))));
                __builder2.AddAttribute(72, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AuthUser.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.AddMarkupContent(74, "<div class=\"row\"><div class=\"col text-right\"><button class=\"btn btn-primary\" type=\"submit\">Сохранить</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
