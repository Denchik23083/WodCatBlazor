#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d82f4a43d5228a847cfce6306e99e9d645d25efa"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
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
    public partial class AddEditHallComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "formAddHall mt-3 p-3");
            __builder.AddMarkupContent(2, "<div class=\"row\"><div class=\"col\"><h2 class=\"mainInfoAboutHall mb-3\">Основная информация о клубе</h2></div></div>    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-6");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col");
            __builder.AddMarkupContent(11, "<h5 style=\"color: white;\">Выберите логотип</h5>\r\n                    ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "class", "select form-control");
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                                                   Image

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "None");
            __builder.AddMarkupContent(17, "Эмблема");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                         foreach (var item in HallEmblem)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                            item.Image

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
__builder.AddContent(20, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                               _image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(32);
            __builder.AddAttribute(33, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                             Hall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 30 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                             Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(38);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "selectedFormResult mb-2 mr-2");
                __builder2.AddAttribute(46, "placeholder", "Имя Клуба");
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                         Hall.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hall.Name = __value, Hall.Name))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Hall.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "row");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col mb-2");
                __builder2.OpenElement(55, "select");
                __builder2.AddAttribute(56, "class", "selectedFormResult mb-2");
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                                                           Type

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 44 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                             foreach (var item in HallTypes)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", 
#nullable restore
#line 46 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                                item.Value

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
__builder2.AddContent(60, item.Content);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 49 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "row");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col mb-2");
#nullable restore
#line 56 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                         foreach (var item in SelectedType)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(66, "span");
                __builder2.AddAttribute(67, "class", "foo");
#nullable restore
#line 58 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
__builder2.AddContent(68, item);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(69, "\r\n                                ");
                __builder2.OpenElement(70, "button");
                __builder2.AddAttribute(71, "class", "selectedTypeClose");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                                                            () => RemoveSelectedType(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "type", "button");
                __builder2.AddMarkupContent(74, "<span aria-hidden=\"true\">&times;</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "<br>");
#nullable restore
#line 63 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "row");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col mb-2");
                __builder2.OpenElement(81, "select");
                __builder2.AddAttribute(82, "class", "selectedFormResult mb-2");
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                                                           TownValue

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "None");
                __builder2.AddMarkupContent(86, "Город");
                __builder2.CloseElement();
#nullable restore
#line 70 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                             foreach (var item in Town)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(87, "option");
                __builder2.AddAttribute(88, "value", 
#nullable restore
#line 72 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                                item.Filter

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 73 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
__builder2.AddContent(89, item.Content);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "row");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(95);
                __builder2.AddAttribute(96, "class", "selectedFormResult mb-2");
                __builder2.AddAttribute(97, "placeholder", "Адрес");
                __builder2.AddAttribute(98, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                         Hall.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hall.Location = __value, Hall.Location))));
                __builder2.AddAttribute(100, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Hall.Location));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "row");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(106);
                __builder2.AddAttribute(107, "class", "selectedFormResult mb-2");
                __builder2.AddAttribute(108, "placeholder", "Рейтинг от 1 до 10");
                __builder2.AddAttribute(109, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                         Hall.Rating

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hall.Rating = __value, Hall.Rating))));
                __builder2.AddAttribute(111, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Hall.Rating));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "row");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col mb-2");
                __builder2.OpenElement(117, "textarea");
                __builder2.AddAttribute(118, "placeholder", "Описание");
                __builder2.AddAttribute(119, "class", "textarea");
                __builder2.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                                       Hall.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Hall.Description = __value, Hall.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "row");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col text-right");
#nullable restore
#line 106 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                         if (!IsDisplaySubmitButton)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(127, "<button class=\"btn btn-primary\" disabled=\"disabled\" type=\"submit\">Сохранить</button>");
#nullable restore
#line 112 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(128, "<button class=\"btn btn-primary\" type=\"submit\">Сохранить</button>");
#nullable restore
#line 118 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\AddEditHallComponent.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591