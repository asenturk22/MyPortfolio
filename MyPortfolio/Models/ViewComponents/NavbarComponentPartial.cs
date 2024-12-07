using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents
{
    public class NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
