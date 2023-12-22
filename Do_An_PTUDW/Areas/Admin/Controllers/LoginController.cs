using Microsoft.AspNetCore.Mvc;
using Do_An_PTUDW.Areas.Admin.Models;
using Do_An_PTUDW.Models;
using Do_An_PTUDW.Utilities;

namespace Do_An_PTUDW.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminUser user)
        {
            if (user == null)
            {
                return NotFound();
            }
            string pw = Functions.MD5Password(user.Password);
            var check = _context.Admins.Where(m => (m.Email == user.Email) && (m.Password == pw)).FirstOrDefault();
            if (check == null)
            {
                Functions._Message = "Invalid UserName or Password!";
                return RedirectToAction("Index", "Login");
            }
            Functions._Message = string.Empty;
            Functions._UserID = check.UserID;
            Functions._UserName = string.IsNullOrEmpty(check.UserName) ? string.Empty : check.UserName;
            Functions._Email = string.IsNullOrEmpty(check.Email) ? string.Empty : check.Email;
            Functions._Avatar = string.IsNullOrEmpty(check.Avatar) ? string.Empty : check.Avatar;
            Functions._Company = string.IsNullOrEmpty(check.Company)? string.Empty : check.Company;
            Functions._Job = string.IsNullOrEmpty(check.Job) ? string.Empty : check.Job;
            Functions._Country = string.IsNullOrEmpty(check.Country) ? string.Empty : check.Country;
            Functions._Address = string.IsNullOrEmpty(check.Address) ? string.Empty : check.Address;
            Functions._Phone = string.IsNullOrEmpty(check.Phone) ? string.Empty : check.Phone;

            return RedirectToAction("Index", "Home");
        }
    }
}
