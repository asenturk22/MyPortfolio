using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
