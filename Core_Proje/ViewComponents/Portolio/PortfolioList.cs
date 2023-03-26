

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
