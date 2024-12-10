using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents.LayoutViewComponents
{
    public class LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
