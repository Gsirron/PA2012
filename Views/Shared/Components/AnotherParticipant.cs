using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;
using System.Threading.Tasks;

namespace Prototype.Views.Shared.Components
{
    public class AnotherParticipant : ViewComponent
    {
        private readonly PrototypeContext _context;

        public AnotherParticipant(PrototypeContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sitedata = await _context.SiteData.FirstOrDefaultAsync(x => x.SiteData_Active == true);

            if (sitedata == null)
            {

                return Content(string.Empty);
            }

            ViewData["Phase"] = sitedata.SiteData_Phase;


            return View();
        }
    }
}
