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
    public partial class DisplayRecipe : Window
    {
        public List<Recipe> Recipes { get; set; }
        public Recipe SelectedRecipe { get; set; }

        public DisplayRecipe(List<Recipe> recipes)
        {
            InitializeComponent();
            Recipes = recipes;
            DataContext = this;
        }

        private void RecipeComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            SelectedRecipe = (sender as ComboBox).SelectedItem as Recipe;
        }
        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe();
            addRecipe.Show();

        }

        private void ManageRecipe_Click(object sender, RoutedEventArgs e)
        {
            ManageRecipe manageRecipe = new ManageRecipe();
            manageRecipe.Show();
            this.Close();
        }
    }
}
