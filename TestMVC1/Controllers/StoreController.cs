using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string Browse(string genre)
        {
            string msg = HttpUtility.HtmlEncode("name=" + genre);
            return msg;
        }

        public string Details(string text, int id)
        {
            string msg = text + ";id=" + id;
            return msg;
        }
    }
}