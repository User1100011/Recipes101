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
            //����� ����� ������ ����� ������ � �� ����� ������ � ����� ���� ����� ������ Id ������� � �������� ��������� RedirectToPage("RecipePage")

            RedirectToPage("RecipePage");
        }
        public void OnGet()
        {

        }
    }
}
