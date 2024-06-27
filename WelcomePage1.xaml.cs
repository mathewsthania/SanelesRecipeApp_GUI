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
    /// Interaction logic for WelcomePage1.xaml
    /// </summary>
    public partial class WelcomePage1 : Page
    {
        public WelcomePage1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage1());
        }

    }
}
