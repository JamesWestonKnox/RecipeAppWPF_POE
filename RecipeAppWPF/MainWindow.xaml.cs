using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeAppWPF
{

    public partial class MainWindow : Window
    {
        public static List<Recipe> Recipes = new List<Recipe>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe();
            addRecipe.ShowDialog(); 

            if (addRecipe.currentRecipe != null)
            {
                Recipes.Add(addRecipe.currentRecipe);
            }
            this.Close();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipe displayRecipe = new DisplayRecipe(Recipes);
            displayRecipe.Show();
            this.Close();
        }

        private void ManageRecipe_Click(object sender, RoutedEventArgs e)
        {
            ManageRecipe manageRecipe = new ManageRecipe();
            manageRecipe.Show();
            this.Close();
        }
    }
}