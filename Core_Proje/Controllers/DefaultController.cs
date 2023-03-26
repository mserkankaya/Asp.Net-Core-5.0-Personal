using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial() 
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage() 
        { 
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManager.TAdd(p);
            return PartialView();
        }
    }
}
