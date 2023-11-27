using Do_An_PTUDW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Do_An_PTUDW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }


       
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/categori-{slug}-{id:long}.html", Name = "Details")]
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var menu = _dataContext.Menus
                .FirstOrDefault(m => (m.MenuID == id) && (m.IsActive == true));
            if (menu == null)
            {
                return NotFound();
            }
            ViewBag.Blog = _dataContext.Blogs.Where(i => i.IDMenu == id && i.IsActive == true).ToList();

            return View(menu);
        }

        [Route("/SinglePost-{slug}-{id:long}.html", Name = "SinglePost")]
        public IActionResult SinglePost(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var singlepost = _dataContext.Blogs
                .FirstOrDefault(m => (m.IDBlog == id) && (m.IsActive == true) );
            ViewBag.SinglePost = _dataContext.Blogs.Where(i => i.IDBlog == id ).ToList();
            if (singlepost == null)
            {
                return NotFound();
            }
           

            return View(singlepost);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}