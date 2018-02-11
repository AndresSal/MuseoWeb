using System.Web.Mvc;

namespace MuseoVirtual.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Inicio()
        {
            return View();
        }
    }
}