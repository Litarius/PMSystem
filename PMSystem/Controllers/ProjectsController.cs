using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMSystem.ViewModels.Projects;

namespace PMSystem.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNewProject()
        {
            return View(new AddNewProjectViewModel());
        }

        public ActionResult Issues()
        {
            var model = new IssuesViewModel();
            return View(model);
        }

        public ActionResult AddNewIssue()
        {
            return View();
        }
    }
}