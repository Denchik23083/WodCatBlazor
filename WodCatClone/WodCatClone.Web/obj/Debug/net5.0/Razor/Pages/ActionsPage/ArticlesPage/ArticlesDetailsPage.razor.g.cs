#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f43be2183a4b725d8693e67dbd9b7ef0c13738f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/articles/{ArticleId:int}")]
    public partial class ArticlesDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(9, "<a href=\"/articles\" class=\"link\">Статьи</a>&nbsp;&rarr;&nbsp;\r\n            ");
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(10, Article.Name);

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
#line 15 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(18, Article.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
             foreach (var item in Article.Type.Split(","))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "cubId");
#nullable restore
#line 18 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(21, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
     if (Image is not null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row mb-2");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-5");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "exercisesId p-3");
#nullable restore
#line 27 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                     if (Article.Rating is null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(28, Article.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                            
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row mb-2");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
#nullable restore
#line 35 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(33, Article.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col");
#nullable restore
#line 40 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(39, Article.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, " / 10\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-3");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "exercisesId p-3");
            __builder.OpenElement(46, "img");
            __builder.AddAttribute(47, "src", 
#nullable restore
#line 48 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "style", "width: 100%; height: auto;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, @"<div class=""col-4""><div class=""exercisesId p-3""><span style=""color: blue"">7 причин, почему нужно заниматься CrossFit
                        The Role of Skeletal Muscle Insulin Resistance in the Pathogenesis of the Metabolic Syndrome
                        How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?</span></div></div>");
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row mb-2");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-6");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "exercisesId p-3");
#nullable restore
#line 65 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                     if (Article.Rating is null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(57, Article.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                                            
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row mb-2");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col");
#nullable restore
#line 73 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(62, Article.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "row");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col");
#nullable restore
#line 78 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(68, Article.Rating);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, " / 10\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.AddMarkupContent(71, @"<div class=""col-6""><div class=""exercisesId p-3""><span style=""color: blue"">7 причин, почему нужно заниматься CrossFit
                        The Role of Skeletal Muscle Insulin Resistance in the Pathogenesis of the Metabolic Syndrome
                        How do U.S. Marines stack up when it comes to conquering the Navy SEALs fitness test?</span></div></div>");
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<div class=\"row\"><div class=\"col\"><h2 class=\"NameId\">Описание</h2></div></div>\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "full");
#nullable restore
#line 100 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\Pages\ActionsPage\ArticlesPage\ArticlesDetailsPage.razor"
__builder.AddContent(79, Article.FullDescription);

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
