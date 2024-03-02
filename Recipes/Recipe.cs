using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Recipes
{
    public class Recipe
    {
        private static int currnetId = 0;

        public int Id { get; init; }

        [Required] public string Name { get; set; }
        [Required] public string Discription { get; set; }
        [Required] [Range(0, 120)] public int CookingMinutesTime { get; set; }
        //[Required] public List<Step> Steps { get; set; }
        [Required] public string Steps { get; set; }
        public Recipe()
        {
            currnetId++;
            Id = currnetId;
        }
    }
}
