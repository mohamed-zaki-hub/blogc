using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Diagnostics;

namespace src.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;


        NewsContext db;
        public HomeController(NewsContext db)
        {
            this.db = db;
            //  _logger = logger;
        }

        public IActionResult Index()
        {
            var List =db.Categories.ToList();
            return View(List);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult News(int id)
        {
            Category c = db.Categories.Find(keyValues: id);
            ViewBag.Cat = c.Name;

            var result = db.News.Where(x=>x.CategoryId == id).OrderByDescending(x=>x.Date).ToList();
            return View(result);
        }

        [HttpPost]
        public IActionResult SaveContact(ContactUS model)
        {
            db.Contacts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}