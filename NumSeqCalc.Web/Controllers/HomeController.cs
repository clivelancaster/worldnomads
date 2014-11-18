using NumSeqCalc.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumSeqCalc.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Calculate()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult GetCalculatedResult(string number)
        {
            var CalculateService = new CalculateService();
            var resultList = CalculateService.GetCalculatedResult(number);
            return Json(resultList);
        }
    }
}