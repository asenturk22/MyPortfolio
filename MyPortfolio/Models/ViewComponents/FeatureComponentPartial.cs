using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Models.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portofolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portofolioContext.Features.ToList();

            return View(values);
        }
    }
}
