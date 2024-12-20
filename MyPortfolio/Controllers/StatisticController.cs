using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext m_context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = m_context.Skills.Count();
            ViewBag.v2 = m_context.Messages.Count();
            ViewBag.v3 = m_context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = m_context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
