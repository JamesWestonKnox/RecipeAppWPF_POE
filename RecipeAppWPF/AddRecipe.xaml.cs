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
        private Recipe currentRecipe;

        public AddRecipe()
        {
            InitializeComponent();
            currentRecipe = new Recipe();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipe displayRecipe = new DisplayRecipe();
            displayRecipe.Show();
            this.Close();
        }

        private void ManageRecipe_Click(object sender, RoutedEventArgs e)
        {
            ManageRecipe manageRecipe = new ManageRecipe();
            manageRecipe.Show();
            this.Close();
        }

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

        private void AddStepButton_Click(object sender, RoutedEventArgs e)
        {
            string step = StepTextBox.Text;
            currentRecipe.AddStep(step);

            StepTextBox.Clear();
        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            currentRecipe.RecipeName = recipeName;

            MessageBox.Show("Recipe saved successfully!");

            RecipeNameTextBox.Clear();
        }
    }
}