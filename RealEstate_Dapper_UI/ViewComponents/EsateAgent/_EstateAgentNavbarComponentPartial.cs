﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.EsateAgent
{
    public class _EstateAgentNavbarComponentPartial : ViewComponent
    { 
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
