#pragma checksum "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6d7c961641dc5509d77d73c12c599d7ce0833b"
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
#nullable restore
#line 20 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\_Imports.razor"
using WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent;

#line default
#line hidden
#nullable disable
    public partial class HallsInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor"
 if (!IsLoginUser)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col p-0\"><h1 class=\"text-light\" style=\"font-size: 30px;\">Кроссфит залы и тренажерные залы с кроссфит зоной Украина 2022</h1></div></div>\r\n        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col text-right text-muted mb-2 p-0");
            __builder.OpenElement(5, "i");
            __builder.AddAttribute(6, "class", "fa-solid fa-info info");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor"
                                                           () => IsDisplay = !IsDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor"
         if (IsDisplay)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col p-0 mb-3");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "halls p-3");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn hide mb-2");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor"
                                                                () => IsDisplay = !IsDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "Скрыть");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.AddMarkupContent(19, @"<p><strong>Кроссфит зал</strong> – это специально оборудованное место для занятий Кроссфитом, которое отличается от простых тренажерных залов, просторным помещением с высокими потолками для комфортных занятий групп 10-15 человек. В большей части, кроссфит залы размещены в ангарах или старых производственных зданиях. В кроссфит залах предъявляет высокие требования к прочности бетонных перекрытий для выполнения элементов тяжелой атлетики либо тех, которые требуют специальной подготовки пола (использование помостов).</p>
                        ");
            __builder.AddMarkupContent(20, "<p>Преимуществом любого профессионального зала является наличие открытой площадки для выполнения на улице комплексов, содержащих беговые упражнения.</p>\r\n                        ");
            __builder.AddMarkupContent(21, @"<p><strong>Кроссфит залы</strong>бывают 2-х типов.<strong>Аффилированный зал</strong> - зал, в котором тренировки осуществляют сертифицированные тренера Кроссфита и имеется подтвержденное право на использование названия Кроссфит в своей деятельности.</p>
                        ");
            __builder.AddMarkupContent(22, "<p><strong>Не аффилированный зал</strong> - залы, в которых тренировки осуществляют тренера по другим видам спорта, такой зал не имеет право называться кроссфит залом.</p>\r\n                        ");
            __builder.AddMarkupContent(23, @"<p>Отличительной особенностью профессионального зала для кроссфита - это отсутствие блочных тренажеров. Основное оборудование: стойки и инвентарь для занятий с свободными весами. Из тренажеров возможно только наличие кардио тренажеров</p>
                        ");
            __builder.AddMarkupContent(24, @"<p><strong>ВОДКАТ залы</strong> - это каталог спортивных залов, фитнес центров, кроссфит залов. На странице поиска вы сможете найти зал, который расположен в удобном для вас месте, оборудование которого отвечает Вашим требованиям, познакомиться с деятельностью популярных залов и присоединиться к группе спортсменов (подписаться).</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\User\source\repos\WodCatBlazor\WodCatClone\WodCatClone.Web\PageComponents\ActionsComponent\HallsComponent\HallsInfo.razor"
         
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
