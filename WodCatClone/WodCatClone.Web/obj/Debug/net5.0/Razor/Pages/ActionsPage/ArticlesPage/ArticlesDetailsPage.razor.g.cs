#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d57db36c7c57a4e4c76ab8af8d244893a89a9623"
// <auto-generated/>
#pragma warning disable 1591
namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/articles/{ArticleId:int}")]
    public partial class ArticlesDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WodCatClone.Web.PageComponents.HeaderComponent.HeaderComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent.ConfirmRemoveArticle>(2);
            __builder.AddAttribute(3, "OnCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
              OnCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnShow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
            OnShow

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Article", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WodCatClone.Db.Entities.Actions.Articles>(
#nullable restore
#line 9 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
             Article

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ArticleId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
               ArticleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 6 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
          ConfirmRemoveArticle = (WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent.ConfirmRemoveArticle)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "wrapperId");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mb-2");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col text-left text-light pages");
            __builder.AddMarkupContent(15, "<a href=\"/\" class=\"link\">WODCAT</a>&nbsp;&rarr;&nbsp;\r\n            ");
            __builder.AddMarkupContent(16, "<a href=\"/articles\" class=\"link\">Статьи</a>&nbsp;&rarr;&nbsp;\r\n            ");
#nullable restore
#line 17 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(17, Article.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
         if (User is not null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
             if (User.Id == Article.UserId)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-6 text-right text-light pages mb-3");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary text-white");
            __builder.AddAttribute(22, "style", "font-weight: bold;");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                  Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "Редактировать\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-danger text-white");
            __builder.AddAttribute(28, "style", "font-weight: bold;");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                  OnShow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n                        Удалить\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row mb-2");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "NameId");
#nullable restore
#line 41 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(38, Article.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
             if (Article.Type is not null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                 foreach (var item in Article.Type.Split(","))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "span");
            __builder.AddAttribute(40, "class", "cubId");
#nullable restore
#line 46 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(41, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
     if (Image is not null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row mb-2");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-5");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "exercisesId p-3");
#nullable restore
#line 56 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                     if (Article.Rating is null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(48, Article.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                            
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row mb-2");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col");
#nullable restore
#line 64 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(53, Article.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col");
#nullable restore
#line 69 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(59, Article.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, " / 10\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-3");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "exercisesId p-3");
            __builder.OpenElement(66, "img");
            __builder.AddAttribute(67, "src", 
#nullable restore
#line 77 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "style", "width: 100%; height: auto;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.AddMarkupContent(70, @"<div class=""col-4""><div class=""exercisesId p-3""><span style=""color: blue"">7 причин, почему нужно заниматься CrossFit
                        The Role of Skeletal Muscle Insulin Resistance in the Pathogenesis of the Metabolic Syndrome
                        How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?</span></div></div>");
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row mb-2");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-6");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "exercisesId p-3");
#nullable restore
#line 94 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                     if (Article.Rating is null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                         if (Article.Description is not null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(77, Article.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                                
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row mb-2");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col");
#nullable restore
#line 105 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                 if (Article.Description is not null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(82, Article.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                                        
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col");
#nullable restore
#line 113 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(88, Article.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, " / 10\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 116 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.AddMarkupContent(91, @"<div class=""col-6""><div class=""exercisesId p-3""><span style=""color: blue"">7 причин, почему нужно заниматься CrossFit
                        The Role of Skeletal Muscle Insulin Resistance in the Pathogenesis of the Metabolic Syndrome
                        How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?</span></div></div>");
            __builder.CloseElement();
#nullable restore
#line 127 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
     if (Article.FullDescription is not null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(92, "<div class=\"row\"><div class=\"col\"><h2 class=\"NameId\">Описание</h2></div></div>\r\n        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "col");
            __builder.OpenElement(97, "p");
            __builder.AddAttribute(98, "class", "full");
#nullable restore
#line 137 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(99, Article.FullDescription);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 140 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
