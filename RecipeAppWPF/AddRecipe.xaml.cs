using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeAppWPF
{

    public partial class AddRecipe : Window
    {
        public static List<Recipe> Recipes = new List<Recipe>();

        public Recipe currentRecipe;

        public AddRecipe()
        {
            InitializeComponent();
            currentRecipe = new Recipe();
        }

        //redirect method
        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipe displayRecipe = new DisplayRecipe(Recipes);
            displayRecipe.Show();
            this.Close();
        }

        //redirect method
        private void ManageRecipe_Click(object sender, RoutedEventArgs e)
        {
            ManageRecipe manageRecipe = new ManageRecipe();
            manageRecipe.Show();
            this.Close();
        }

        //method to populate recipe with ingredient by taking user input through text boxes and combo boxes
        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            string ingrName = IngredientNameTextBox.Text;
            if (double.TryParse(IngredientQtyTextBox.Text, out double ingrQty) &&
                double.TryParse(IngredientCaloriesTextBox.Text, out double ingrCalories))
            {
                string ingrUnit = IngredientUnitTextBox.Text;
                string ingrFoodGroup = (IngredientFoodGroupComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

                currentRecipe.AddIngredient(ingrName, ingrQty, ingrUnit, ingrCalories, ingrFoodGroup);

                IngredientNameTextBox.Clear();
                IngredientQtyTextBox.Clear();
                IngredientUnitTextBox.Clear();
                IngredientCaloriesTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid quantities and calories.");
            }
        }

        //method to add step to recipe
        private void AddStepButton_Click(object sender, RoutedEventArgs e)
        {
            string step = StepTextBox.Text;
            currentRecipe.AddStep(step);

            StepTextBox.Clear();
        }

        //method to save recipe
        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            currentRecipe.RecipeName = recipeName;

            MessageBox.Show("Recipe saved successfully!");

            RecipeNameTextBox.Clear();
        }
    }
}