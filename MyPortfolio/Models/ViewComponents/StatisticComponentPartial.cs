

using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Models.ViewComponents
{
    public class StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
