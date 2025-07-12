using Application.Interfaces.FacadInterface;
using Application.Interfaces.UnitofWork;
using Application.Services.Queries.GetAllItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Peresentation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFacadPattern _facad;
        public IndexModel(IFacadPattern facad) => _facad = facad;
        // Page Load
        public async Task<JsonResult> OnGetData()
        {
            return new JsonResult(await _facad.getAllItems.ExecuteAsync());
        }

        public void OnPost()
        {

        }
    }
}
