using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForFeds.Models;

namespace MvcForFeds.Controllers
{
    public class FedController : Controller
    {
        // GET: Fed
        public ActionResult Index()
        {
            var model = (IEnumerable<FedViewModel>) Session["Feds"];
            return View(model);
        }

        public ActionResult View(int id)
        {
            var model = ((IEnumerable<FedViewModel>) Session["Feds"]).FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(FedViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Dislikes = model.DislikesInput.Split(',').ToList();
            var feds = (List<FedViewModel>) Session["Feds"];
            var id = feds.Max(x => x.Id) + 1;
            model.Id = id;
            feds.Add(model);
            Session["Feds"] = feds;

            return RedirectToAction(nameof(Index));
        }
    }
}