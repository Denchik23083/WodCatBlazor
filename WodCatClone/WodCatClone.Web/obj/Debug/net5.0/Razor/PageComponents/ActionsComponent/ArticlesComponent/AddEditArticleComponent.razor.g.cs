#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a4be4426e874643af99009033497e8266a4e75"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
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
    public partial class AddEditArticleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "formAddHall mt-3 p-3");
            __builder.AddMarkupContent(2, "<div class=\"row\"><div class=\"col\"><h2 class=\"mainInfoAboutHall mb-3\">Основная информация о статьи</h2></div></div>    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-6");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col mb-2");
            __builder.AddMarkupContent(11, "<h5 style=\"color: white;\">Выберите логотип</h5>\r\n                    ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "class", "select form-control");
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                                                   SelectedImage

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "None");
            __builder.AddMarkupContent(17, "Эмблема");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                         foreach (var item in ArticlesEmblem)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                            item.Image

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
__builder.AddContent(20, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
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
#nullable restore
#line 25 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                     if (Image is not "None")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                   Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "width", "150");
            __builder.AddAttribute(29, "height", "150");
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                    }                    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(33);
            __builder.AddAttribute(34, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 33 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                             Article

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 33 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                                Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "selectedFormResult mb-2 mr-2");
                __builder2.AddAttribute(43, "placeholder", "Имя Статьи");
                __builder2.AddAttribute(44, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                         Article.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Article.Name = __value, Article.Name))));
                __builder2.AddAttribute(46, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Article.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col mb-2");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "selectedFormResult");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                                                  () => IsShow = !IsShow

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(55, "Тип");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "row");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col");
#nullable restore
#line 49 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                         if (IsShow)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                             if (ArticleTypes.Count is not 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "selected mb-2");
#nullable restore
#line 54 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                     foreach (var item in ArticleTypes)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(63, "span");
                __builder2.AddAttribute(64, "class", "item mb-2");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                                                          () => AddArticleType(item.Value)

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 56 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
__builder2.AddContent(66, item.Content);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "<br>");
#nullable restore
#line 57 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 59 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                            }
                            else
                            {
                                IsShow = false;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                             
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col mb-2");
#nullable restore
#line 69 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                         foreach (var item in SelectedType)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(73, "span");
                __builder2.AddAttribute(74, "class", "foo");
#nullable restore
#line 71 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
__builder2.AddContent(75, item);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(76, "\r\n                                ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "class", "selectedTypeClose p-0 mr-3");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                                                                     () => RemoveSelectedType(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "type", "button");
                __builder2.AddMarkupContent(81, "<span aria-hidden=\"true\">&times;</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "row");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(87);
                __builder2.AddAttribute(88, "class", "selectedFormResult mb-2");
                __builder2.AddAttribute(89, "placeholder", "Рейтинг от 1 до 10");
                __builder2.AddAttribute(90, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                         Article.Rating

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Article.Rating = __value, Article.Rating))));
                __builder2.AddAttribute(92, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Article.Rating));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col mb-2");
                __builder2.OpenElement(98, "textarea");
                __builder2.AddAttribute(99, "placeholder", "Описание");
                __builder2.AddAttribute(100, "class", "textarea");
                __builder2.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                       Article.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Article.Description = __value, Article.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "row");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col mb-2");
                __builder2.OpenElement(108, "textarea");
                __builder2.AddAttribute(109, "placeholder", "Полное описание");
                __builder2.AddAttribute(110, "class", "textarea");
                __builder2.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 101 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                                       Article.FullDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Article.FullDescription = __value, Article.FullDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "row");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col text-right");
#nullable restore
#line 107 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                         if (!IsDisplaySubmitButton)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(118, "<button class=\"btn btn-primary\" disabled=\"disabled\" type=\"submit\">Сохранить</button>");
#nullable restore
#line 113 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(119, "<button class=\"btn btn-primary\" type=\"submit\">Сохранить</button>");
#nullable restore
#line 119 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\ArticlesComponent\AddEditArticleComponent.razor"
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
