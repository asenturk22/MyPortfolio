using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents
{
    public class ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
