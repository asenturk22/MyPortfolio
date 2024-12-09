using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Models.ViewComponents
{
    public class ExperienceComponentPartial : ViewComponent 
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
