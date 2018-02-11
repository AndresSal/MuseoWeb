using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuseoVirtual.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Show_Map()
        {
            return View();
        }
    }
}