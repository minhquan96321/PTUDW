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
            var mnList = (from m in _context.Contacts
                          select new SelectListItem()
                          {
                              Text = m.UserName,
                              Value = m.ContactID.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = "0"

            });
            ViewBag.mnList = mnList;

            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Index(Contact ct)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(ct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ct);
        }




    }
}
