using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents
{
    public class TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
