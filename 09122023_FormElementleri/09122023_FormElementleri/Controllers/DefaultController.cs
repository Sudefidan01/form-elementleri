using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09122023_FormElementleri.Controllers
{
    public class DefaultController : Controller
    {
        List<SelectListItem> sehirler=new List<SelectListItem>()
        {
            new SelectListItem(){Text="İstanbul",Value="34"},
            new SelectListItem(){Text="Çanakkale",Value="17"},
            new SelectListItem(){Text="Bursa",Value="16"},
            new SelectListItem(){Text="Mersin",Value="33"}
        };
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Sehirler = sehirler;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string ad,string mesaj , bool html,bool csharp,bool python,int? rbCinsiyet,string sifre)
        {

            ViewBag.Sehirler = sehirler;
            return View();
        }
    }
}