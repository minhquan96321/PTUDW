using Do_An_PTUDW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Do_An_PTUDW.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Create(Contact ct)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(ct);
                _context.SaveChanges();
                TempData["Altermessage"] = "Liên hệ thành công";
                return RedirectToAction("Index");
            }
            return View();
        }




    }
}
