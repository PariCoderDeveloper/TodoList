using Application.Interfaces.FacadInterface;
using Application.Interfaces.UnitofWork;
using Application.Services.Queries.GetAllItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Peresentation.Models;

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
        [BindProperty]
        public AddItemModel ItemModel { get; set; }
        public async Task<JsonResult> OnPostAddItem([FromBody] AddItemModel item)
        {
            var res = new Application.Services.DTOs.ItemDto
            {
                Title = item.Title,
                IsCompleted = false,
                date = DateOnly.FromDateTime(item.date)
            };
            await _facad.addItemService.Execute(res);
            RedirectToAction("OnGetData");
            return new JsonResult(res);

        }

        [BindProperty]
        public EditItemModel itemModel { get; set; }
        public async Task<JsonResult> OnPostEditAsync([FromBody] EditItemModel item)
        {
            var res = await _facad.editItemService.ExecuteAsync(new Application.Services.Commands.EidtItem.EditItemDto
            {
                ID = item.ID,
                Title = item.Title,
                IsCompleted = item.IsCompleted,
                date = DateOnly.FromDateTime(item.date),
            });
            return new JsonResult(res);
        }

        public async Task<JsonResult> OnPostDeleteAsync(long id)
        {
            return new JsonResult(await _facad.deleteItemService.ExecuteAsync(id));
        }

        public async Task<JsonResult> OnPostCompleted([FromBody] long id)
        {
            return new JsonResult(await _facad.CompeletedService.ExecuteAsync(id));
        } 
    }
}
