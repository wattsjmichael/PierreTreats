using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SweetTreats.Models;

namespace SweetTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly SweetTreatsContext _db;

      public HomeController(SweetTreatsContext db)

      {
        _db=db;
      }
      [HttpGet("/")]
        public ActionResult Index()
        {
            Dictionary<string, object> joinFlavorTreat = new Dictionary<string, object>();
            List<Flavor> flavors = _db.Flavors.ToList();
            List<Treat> treats = _db.Treats.ToList();
            joinFlavorTreat.Add("flavors", flavors);
            joinFlavorTreat.Add("treats", treats);
            return View(joinFlavorTreat);
        }
    }
}
