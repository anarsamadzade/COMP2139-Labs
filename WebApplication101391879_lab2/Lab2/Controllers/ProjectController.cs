using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProjectsController : Controller
    {
        private static List<Project> projects = new List<Project>();

        public IActionResult Index()
        {
            var projects = new List<Project>
            {
                new Project(1, "Project 1 ", "First Project")
                // feel free to add more sample projects here
            };
            return View(projects);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // Change this to HttpPost to differentiate from the HttpGet Create method
        public IActionResult Create(Project project)
        {
            projects.Add(project);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var project = projects.Find(p => p.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }
    }
}
