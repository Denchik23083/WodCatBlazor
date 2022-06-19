﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class AboutHallComponent
    {
        [Parameter] public Halls Hall { get; set; }

        [Parameter] public int Athletes { get; set; }
    }
}