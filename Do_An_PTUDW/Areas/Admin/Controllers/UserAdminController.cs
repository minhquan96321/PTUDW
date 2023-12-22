using Microsoft.AspNetCore.Mvc;
using Do_An_PTUDW.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Do_An_PTUDW.Utilities;

namespace Do_An_PTUDW.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserAdminController : Controller
    {
        public IActionResult Index()
        {
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
