using Application.Interfaces.FacadInterface;
using Application.Services.Queries.GetAllItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Peresentation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IFacadPattern _facad;

        public IndexModel( IFacadPattern facad)
        {
            _facad = facad;
        }
        // Page Load
        public JsonResult OnGetData()
        {
           return new JsonResult(_facad.getAllItems.GetAllItemService(0));
        }

        public void OnPost() 
        {

        }
    }
}
