using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HelloAngularApp.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment env;
        public HomeController(IHostingEnvironment env)
        {
            this.env = env;
        }
        public IActionResult Index()
        {
            // return new PhysicalFileResult(Path.Combine(env.WebRootPath, "index.html"), "text/html");
            return View(); // если определено view
        }
    }
}