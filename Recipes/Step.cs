using System.ComponentModel.DataAnnotations;

namespace Recipes
{
    public class Step
    {
        [Required] public string ImagePath;
        [Required] public string Discription;
    }
}
