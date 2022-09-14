using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleDataLibrary.Data;

namespace NorthwindM.Pages
{
    public class CategoriasModel : PageModel
    {
        public List<Category>? Categories { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind WEB - Categorias";
            using (SampleDataLibrary.Data.Northwind db = new())
            {
                Categories =db.Categories.ToList();
            }
        }
    }
}
