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
    /// <summary>
    /// Interaction logic for ManageRecipe.xaml
    /// </summary>
    public partial class ManageRecipe : Window
    {
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
            DisplayRecipe displayRecipe = new DisplayRecipe();
            displayRecipe.Show();
            this.Close();
        }

    }
}
