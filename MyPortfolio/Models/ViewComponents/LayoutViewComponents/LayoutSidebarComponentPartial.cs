﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents.LayoutViewComponents
{
    public class LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
