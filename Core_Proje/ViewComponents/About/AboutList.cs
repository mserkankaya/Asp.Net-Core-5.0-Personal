using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager _aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = _aboutManager.TGetList();
            return View(values);
        }
    }
}
