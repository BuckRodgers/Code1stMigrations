using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreLib.Persistence;
using CoreLib.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //Add reference of Core to this project (right click on project and add reference)
        private readonly Context _context = new Context();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(_context.Users);
        }

        public ActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
	}
}