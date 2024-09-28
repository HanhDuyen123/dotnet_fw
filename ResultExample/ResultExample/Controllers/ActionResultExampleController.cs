using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultExample.Controllers
{
    public class ActionResultExampleController : Controller
    {
        // GET: ActionResultExample
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult TextPlain()
        {
            return Content("Welcome to ASP.NET MVC");
        }
        public ActionResult FileContent()
        {
            return File("/Controllers/HomeController.cs","text/plain");
        }
        public ActionResult RedirectToAction()
        {
            return RedirectToAction("About","Home");
        }
        public ActionResult RedirectToUrl()
        {
            return Redirect("http://ntu.edu.vn");
        }
        public ActionResult JsonObject()
        {
            var data = new { Name = "Minh", Year = 1978 };
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public ActionResult JavaScriptResult()
        {
            string a = "<script>alert('This is alert!')</script>";
            return Content(a);
            //return JavaScript(a);
        }
    }
}