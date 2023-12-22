using Do_An_PTUDW.Models;
using Microsoft.AspNetCore.Mvc;
namespace Do_An_PTUDW.Areas.Admin.Components
{
    [ViewComponent(Name = "Message")]
    public class MessageComponent : ViewComponent
    {
        private readonly DataContext _context;
        public MessageComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.contacl = _context.Contacts.Count();
            var msList = (from m in _context.Contacts select m).OrderByDescending(ct => ct.ContactID).Take(4).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", msList));
        }
    }
}
