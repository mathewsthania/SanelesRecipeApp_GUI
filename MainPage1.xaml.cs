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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SanelesRecipeApp_GUI
{
    /// <summary>
    /// Interaction logic for MainPage1.xaml
    /// </summary>
    public partial class MainPage1 : Page
    {
        public MainPage1()
        {
            InitializeComponent();
        }

        private void EnterNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EnterRecipeDetailsPage1());
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitApplication_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
