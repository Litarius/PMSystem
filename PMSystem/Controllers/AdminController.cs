using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMSystem.ViewModels.Admin;

namespace PMSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Projects()
        {
            var model = new ProjectsViewModel();
            return View(model);
        }



        public ActionResult CreateProject()
        {
            return View();
        }

        public ActionResult Accounts()
        {
            return View(new AccountViewModel());
        }
    }
}