using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents.LayoutViewComponents
{
    public class LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
