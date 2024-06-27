using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppWPF
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public Dictionary<string, List<(double Quantity, string Unit, double Calories, string FoodGroup)>> Ingredients { get; set; } = new Dictionary<string, List<(double Quantity, string Unit, double Calories, string FoodGroup)>>();
        public List<string> Steps { get; set; } = new List<string>();
        public Dictionary<string, List<(double Quantity, string Unit, double Calories, string FoodGroup)>> OriginalIngredients { get; set; } = new Dictionary<string, List<(double Quantity, string Unit, double Calories, string FoodGroup)>>();

        public event EventHandler<string> HighCalorieContentWarning;

        public Recipe() { }

        public Recipe(string recipeName)
        {
            RecipeName = recipeName;
        }

        public void AddIngredient(string ingredientName, double quantity, string unit, double calories, string foodGroup)
        {
            if (!Ingredients.ContainsKey(ingredientName))
            {
                Ingredients[ingredientName] = new List<(double Quantity, string Unit, double Calories, string FoodGroup)>();
                OriginalIngredients[ingredientName] = new List<(double Quantity, string Unit, double Calories, string FoodGroup)>();
            }

            Ingredients[ingredientName].Add((quantity, unit, calories, foodGroup));
            OriginalIngredients[ingredientName].Add((quantity, unit, calories, foodGroup));

            if (CalculateTotalCalories() > 300)
            {
                HighCalorieContentWarning?.Invoke(this, "Warning: Total calories exceed 300!");
            }
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public double CalculateTotalCalories()
        {
            double totalCalories = 0;
            foreach (var ingredient in Ingredients.Values)
            {
                foreach (var (quantity, unit, calories, foodGroup) in ingredient)
                {
                    totalCalories += calories;
                }
            }
            return totalCalories;
        }
    }
}
