using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


    public partial class ManageRecipe : Window
    {
        public static List<Recipe> Recipes = new List<Recipe>();
        public ManageRecipe()
        {
            InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe();
            addRecipe.Show();
            this.Close();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipe displayRecipe = new DisplayRecipe(Recipes);
            displayRecipe.Show();
            this.Close();
        }

        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
