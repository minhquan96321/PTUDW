using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Do_An_PTUDW.Areas.Admin.Models;
using Do_An_PTUDW.Models;
using Do_An_PTUDW.Utilities;

namespace Do_An_PTUDW.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly DataContext _dataContext;
        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            if(!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            var acc = _dataContext.Admins.Find(Functions._UserID);
            return View(acc);
        }

        [HttpPost]
        public IActionResult Edit(AdminUser AC)
        {
            if(ModelState.IsValid)
            {
                _dataContext.Update(AC);
                _dataContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(AC);
        }
    }
}
