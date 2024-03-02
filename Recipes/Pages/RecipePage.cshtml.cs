using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Recipes.Pages
{
    public class RecipePageModel : PageModel
    {
        public void OnPost(Recipe recipe)
        {
            if (recipe == null || !ModelState.IsValid)
                return;
            //Здесь нужно короче через сервис в бд рецеп кинуть а потом сюда нужно кинуть Id рецепта в качестве паарметра RedirectToPage("RecipePage")

            RedirectToPage("RecipePage");
        }
        public void OnGet()
        {

        }
    }
}
