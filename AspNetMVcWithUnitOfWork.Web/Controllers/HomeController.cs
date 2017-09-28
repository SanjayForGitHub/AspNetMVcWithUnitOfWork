using AspNetMVcWithUnitOfWork.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVcWithUnitOfWork.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactServices _contactServices;
        public HomeController(IContactServices contactServices) {
            _contactServices = contactServices;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";

            return Json(_contactServices.GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}