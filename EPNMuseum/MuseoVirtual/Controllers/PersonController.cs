using MongoDB.Driver;
using MuseoVirtual.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MuseoVirtual.Controllers
{
    public class PersonController : Controller
    {

        public MongoDatabase Database;
        public PersonController()
        {
            var port = 27017;
            var theConnectionString = "mongodb://localhost:" + port;
            var dbName = "test";

            var client = new MongoClient(theConnectionString);
            var server = client.GetServer();
            Database = server.GetDatabase(dbName);

        }

        // GET: Person
        public ActionResult Index()
        {
            Database.GetStats();
            List<Info> names = new List<Info>();
            MongoCollection<Info> Persons = Database.GetCollection<Info>("persons");

            foreach (Info p in Persons.FindAll())
            {
                var name = p.Name;
                names.Add(p);
            }

            return View(names);
            //return Json(Database.Server.BuildInfo, JsonRequestBehavior.AllowGet);
        }


    }
}