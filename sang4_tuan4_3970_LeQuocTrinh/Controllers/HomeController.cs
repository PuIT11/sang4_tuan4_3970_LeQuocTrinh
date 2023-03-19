using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sang4_tuan4_3970_LeQuocTrinh.Models;

namespace sang4_tuan4_3970_LeQuocTrinh.Controllers
{
    public class HomeController : Controller
    {
        myDataDataContext data = new myDataDataContext();
        public ActionResult Index2(int? page )
        {
            if ( page == null ) page = 1;
            var all_sach = (from s in data.Saches select s).OrderBy(m => m.masach);
            int pageSize = 3;
            int pageNum = page ?? 1;
            
            return View(all_sach.ToPagedList(pageNum, pageSize));
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