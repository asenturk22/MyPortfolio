using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext m_context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = m_context.Messages.ToList();

            return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = m_context.Messages.Find(id);
            value.IsRead = true;
            m_context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = m_context.Messages.Find(id);
            value.IsRead = false;
            m_context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = m_context.Messages.Find(id);
            m_context.Messages.Remove(value);
            m_context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetail(int id)
        {
            var value = m_context.Messages.Find(id);
            return View(value);
        }
    }
}
