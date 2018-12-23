using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabWork2.Models;

namespace LabWork2.Controllers
{
    public class HomeController : Controller
    {
        NodeContext db = new NodeContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(string str )
        {

            db.Nodes.Add(new Node {Stroke = str});
            db.SaveChanges();

             return PartialView(db.Nodes);
        }

        [HttpPost]
        public ActionResult Note()
        {
            return PartialView(db.Nodes);
        }
    }
}