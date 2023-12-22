using Do_An_PTUDW.Utilities;
using Microsoft.AspNetCore.Mvc;
using Do_An_PTUDW.Models;

namespace Do_An_PTUDW.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class HomeController : Controller
    {
           private readonly DataContext _dataContext;
        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            if (!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            ViewBag.blog = _dataContext.Blogs.Count();
            ViewBag.contacts = _dataContext.Contacts.Count();
            return View();
        }

        public IActionResult Logout()
        {
            Functions._UserID = 0;
            Functions._UserName = string.Empty;
            Functions._Email = string.Empty;
            Functions._Message = string.Empty;
            Functions._MessageEmail = string.Empty;
            Functions._Avatar = string.Empty;

            return RedirectToAction("Index", "Home");
        }
    }
}
