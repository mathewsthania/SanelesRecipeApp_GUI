using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApp_GUI.Recipe_Classes
{
    public class RecipeIngredient
    {
        public string RecipeName { get; set; }
        public List<RecipeIngredient> Ingredients { get; set;}
        public List<string> Steps { get; set; }


        public RecipeIngredient()
        {
            Ingredients = new List<RecipeIngredient>();
            Steps = new List<string>();
        }
    }
}
