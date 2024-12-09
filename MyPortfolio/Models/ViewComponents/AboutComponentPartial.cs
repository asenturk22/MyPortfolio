using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Models.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            //Title bilgisini getirecek tek bir veri. 
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
