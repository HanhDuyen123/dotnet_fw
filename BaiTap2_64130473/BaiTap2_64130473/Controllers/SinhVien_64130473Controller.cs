using BaiTap2_64130473.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_64130473.Controllers
{
    public class SinhVien_64130473Controller : Controller
    {
        // GET: SinhVien_64130473
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register1(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["Name"];
            ViewBag.Marks = field["Marks"];
            return View(ViewBag);
        }
        public ActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register2()
        {
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Marks = Request["Marks"];
            return View(ViewBag);
        }
        public ActionResult Index3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register3(string Id, string Name, double Marks)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Marks = Marks;
            return View(ViewBag);
        }
        //dùng Models
        public ActionResult Index4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register4(Student st)
        {
            ViewBag.Id = st.Id;
            ViewBag.Name = st.Name;
            ViewBag.Marks = st.Marks;
            return View(ViewBag);
        }
    }
}