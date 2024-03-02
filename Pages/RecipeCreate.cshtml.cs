using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Recipes.Pages
{
    public class RecipeCreateModel : PageModel
    {
        [BindProperty] public Recipe BindingModel { get; set; }
        public void OnGet()
        {

        }
    }
}
