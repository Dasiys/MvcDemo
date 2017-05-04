using Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Address()
        {
            IList<Address> address=new List<Address>();
            UpdateModel(address);
            return View(address);
        }

    }
}