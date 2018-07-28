using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getjson()
        {
            
            var jsondata=Json(Math.PI,JsonRequestBehavior.AllowGet);
            return jsondata;
        }
        public JsonResult GetAllKeys() =>Json(Request.ServerVariables.AllKeys,JsonRequestBehavior.AllowGet);
        public string Getip() => Request.ServerVariables["REMOTE_ADDR"];
        public string Getip2() => Request.UserHostAddress;
       
    }
}