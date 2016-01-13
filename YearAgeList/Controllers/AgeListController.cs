using System.Web.Mvc;
using YearAgeList.Models;

namespace YearAgeList.Controllers
{
    public class AgeListController : Controller
    {
        // GET: AgeList
        public ActionResult Index(int year, int ageMin, int ageMax)
        {
            var list = new AgeList(year, ageMin, ageMax);
            var ages = list.GetList();
            return View(ages);
        }
    }
}