using Microsoft.AspNetCore.Mvc;
using Do_An_PTUDW.Models;
namespace Do_An_PTUDW.Components
{
    [ViewComponent(Name = "About")]
    public class AboutComponent : ViewComponent
    {
        private DataContext _dataContext;
        public AboutComponent(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofAbout = (from m in _dataContext.Abouts select m).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofAbout));
        }
    }
}
