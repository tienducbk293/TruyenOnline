using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TruyenOnline.Models;

namespace TruyenOnline.Controllers
{
    public class HomeController : Controller
    {
        TruyenOnlineEntities db = new TruyenOnlineEntities();
        public ActionResult Index()
        {
            string Chuoi = "";
            var novel = (from p in db.Stories orderby p.ID descending select p).Take(1).ToList();
            for (int i = 0; i < novel.Count; i++)
            {
                Chuoi += "<h2 style = \"text-align:center\" ><b>" + novel[i].ChapName + "</b></h2>";
                Chuoi += "<pre style = \"font-family:Times New Roman; font-size:20px\">" + novel[i].Content +"</pre>";
            }
            ViewBag.View = Chuoi;
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
    }
}