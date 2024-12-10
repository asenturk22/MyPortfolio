using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents.LayoutViewComponents
{
    public class LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
