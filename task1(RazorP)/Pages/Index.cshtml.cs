using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using task1_RazorP_.Data;
using task1_RazorP_.Models;

namespace task1_RazorP_.Pages
{
    public class Index : PageModel
    {
        public List<Product> Product { get; set; }

        public void OnGet()
        {
            Product = ProductData.ListProducts();
        }
    }
}
