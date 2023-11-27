using Do_An_PTUDW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Do_An_PTUDW.Components
{
    [ViewComponent(Name = "Blog")]
    public class PostComponent : ViewComponent
    {
        private DataContext _context;
         public PostComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from m in _context.Blogs
                              where (m.IsActive ==true) select m).ToList();
            ViewBag.Tag = _context.Tags.ToList();
            return await Task.FromResult((IViewComponentResult)View("Post", listofMenu));
        }
    }
}
